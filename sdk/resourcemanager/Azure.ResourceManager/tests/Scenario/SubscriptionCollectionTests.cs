using System;
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
            // Arrange
            var mockSubscriptionCollection = new Mock<SubscriptionCollection>();
            var list = new[] { mockSubscriptionResource.Object };
            mockSubscriptionCollection
                 .Setup(m => m.GetAllAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(new[] { new Mock<SubscriptionResource>().Object }.ToAsyncEnumerable());

            var clientMock = new Mock<ArmClient>();
            clientMock
                .Setup(c => c.GetSubscriptions())
                .Returns(mockSubscriptionCollection.Object);

            int count = 0;

            // Act
            await foreach (var rg in clientMock.Object.GetSubscriptions().GetAllAsync())
            {
                count++;
            }

            // Assert
            Assert.GreaterOrEqual(count, 1);
        }
    }
}
