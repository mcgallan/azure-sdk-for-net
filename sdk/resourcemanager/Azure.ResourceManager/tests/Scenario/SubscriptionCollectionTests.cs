using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Moq;
using NUnit.Framework;

namespace Azure.ResourceManager.Tests
{
    public class SubscriptionCollectionTests : ResourceManagerTestBase
    {
        public SubscriptionCollectionTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task List()
        {
            int count = 0;
            await foreach (var rg in Client.GetSubscriptions().GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 1);
        }

        [RecordedTest]
        public async Task Get()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
            string subscriptionId = subscription.Id.SubscriptionId;
            SubscriptionResource result = await Client.GetSubscriptions().GetAsync(subscriptionId).ConfigureAwait(false);
            Assert.AreEqual(subscriptionId, result.Id.SubscriptionId);

            Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await Client.GetSubscriptions().GetAsync(null).ConfigureAwait(false));
            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => _ = await Client.GetSubscriptions().GetAsync(new Guid().ToString()).ConfigureAwait(false));
            Assert.AreEqual(404, ex.Status);
        }

        [RecordedTest]
        public async Task Exists()
        {
            var expectFalse = await Client.GetSubscriptions().ExistsAsync(new Guid().ToString()).ConfigureAwait(false);
            Assert.IsFalse(expectFalse);
            string subscriptionId = (await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false)).Id.SubscriptionId;
            var expectTrue = await Client.GetSubscriptions().ExistsAsync(subscriptionId).ConfigureAwait(false);
            Assert.IsTrue(expectTrue);
        }

        [RecordedTest]
        public async Task MockList()
        {
            //SubscriptionResource
            var mockSubscriptionResource = new Mock<SubscriptionResource>();
            mockSubscriptionResource.SetupGet(s => s.Data.SubscriptionId).Returns("mock-subscription-id");
            mockSubscriptionResource.SetupGet(s => s.Data.DisplayName).Returns("mock-subscription-name");

            var subscriptionResources = new[] { mockSubscriptionResource.Object };
            var asyncPageable = new CustomAsyncPageable<SubscriptionResource>(subscriptionResources);

            var mockSubscriptionCollection = new Mock<SubscriptionCollection>();
            mockSubscriptionCollection
                .Setup(m => m.GetAllAsync(It.IsAny<CancellationToken>()))
                .Returns(asyncPageable);

            var mockArmClient = new Mock<ArmClient>();
            mockArmClient
                .Setup(c => c.GetSubscriptions())
                .Returns(mockSubscriptionCollection.Object);

            var mockMapper = new Mock<IMapper>();
            mockMapper
                .Setup(m => m.Map<Subscription>(It.IsAny<SubscriptionData>()))
                .Returns((SubscriptionData data) => new Subscription { Id = data.SubscriptionId, Name = data.DisplayName });

            var result = await ListSubscriptionsAsync(mockArmClient.Object, mockMapper.Object);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("mock-subscription-id", result[0].Id);
            Assert.AreEqual("mock-subscription-name", result[0].Name);
        }

        public async Task<List<Subscription>> ListSubscriptionsAsync(ArmClient armClient, IMapper mapper)
        {
            AsyncPageable<SubscriptionResource> subscriptions = armClient
                .GetSubscriptions()
                .GetAllAsync();
            List<Subscription> subscriptionDataList = new List<Subscription>();

            await foreach (SubscriptionResource subscriptionResource in subscriptions)
            {
                subscriptionDataList.Add(mapper.Map<Subscription>(subscriptionResource.Data));
            }

            return subscriptionDataList;
        }

        public class CustomAsyncPageable<T> : AsyncPageable<T>
        {
            private readonly IEnumerable<T> _items;

            public CustomAsyncPageable(IEnumerable<T> items)
            {
                _items = items;
            }

            public override async IAsyncEnumerable<Page<T>> AsPages(string continuationToken = null, int? pageSizeHint = null)
            {
                yield return Page<T>.FromValues(_items, null, null);
                await Task.CompletedTask;
            }
        }

        public class Subscription
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public interface IMapper
        {
            T Map<T>(object source);
        }
    }
}
