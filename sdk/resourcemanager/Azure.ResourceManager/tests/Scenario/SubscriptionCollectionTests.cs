using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using Azure;
using Azure.Core;
using Moq;

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

        [Test]
        public async Task ListSubscriptionsAsync_ReturnsSubscriptionList()
        {
            // Arrange
            var mockArmClient = new Mock<ArmClient>();
            var mockSubscriptionCollection = new Mock<SubscriptionCollection>();
            var mockAsyncPageable = new Mock<AsyncPageable<SubscriptionResource>>();
            var mockAsyncEnumerator = new Mock<IAsyncEnumerator<SubscriptionResource>>();

            mockArmClient.Setup(client => client.GetSubscriptions()).Returns(mockSubscriptionCollection.Object);
            mockSubscriptionCollection.Setup(collection => collection.GetAllAsync(It.IsAny<CancellationToken>())).Returns(mockAsyncPageable.Object);
            mockAsyncPageable.Setup(pageable => pageable.GetAsyncEnumerator(It.IsAny<CancellationToken>())).Returns(mockAsyncEnumerator.Object);

            var subscriptionData = new SubscriptionData()
            {
                Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")
            };
            var subscriptionResource = new Mock<SubscriptionResource>(MockBehavior.Strict, null, subscriptionData);
            var subscriptionList = new List<SubscriptionResource> { subscriptionResource.Object };

            mockAsyncEnumerator.SetupSequence(enumerator => enumerator.MoveNextAsync(It.IsAny<CancellationToken>()))
                .Returns(new ValueTask<bool>(true))
                .Returns(new ValueTask<bool>(false));
            mockAsyncEnumerator.SetupGet(enumerator => enumerator.Current).Returns(subscriptionResource.Object);

            var subscriptionService = new SubscriptionService(mockArmClient.Object);

            // Act
            var result = await subscriptionService.ListSubscriptionsAsync();

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        public async Task<List<Subscription>> ListSubscriptionsAsync(ArmClient armClient)
        {
            AsyncPageable<SubscriptionResource> subscriptions = armClient
                .GetSubscriptions()
                .GetAllAsync();
            List<Subscription> subscriptionDataList = new List<Subscription>();

            await foreach (SubscriptionResource subscriptionResource in subscriptions)
            {
                subscriptionDataList.Add(new Subscription { Id = subscriptionResource.Data.Id });
            }

            return subscriptionDataList;
        }

        public class Subscription
        {
            public string Id { get; set; }
        }
    }
}
