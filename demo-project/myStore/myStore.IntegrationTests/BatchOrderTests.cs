using NSubstitute;
using NUnit.Framework;
using myStore;

namespace myStore.IntegrationTests
{
    [TestFixture]
    public class BatchOrderTests
    {


        [SetUp]
        public void SetUp()
        {

        }


        private BatchOrder CreateBatchOrder()
        {
            return new BatchOrder();
        }

        [Test]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = this.CreateBatchOrder();

            // Act

            // Assert
            Assert.Fail();
        }
    }
}
