using DnDBagOfHolding.Business.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Tests.Utils;
using Moq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DnDBagOfHolding.Tests
{
    [TestClass]
    public class cContainerManagerTests
    {
        private readonly Mock<iContainerManager> mContainerManager = new();

        [TestMethod]
        public async Task Inserting_Data_To_DatabaseAsync()
        {
            // Arrange
            var containerManager = mContainerManager.Object;
            var container = new rMockContainer();
            var dbContext = ; // Assume this is your DbContext for the test, initialized properly

            // Act
            await containerManager.CreateContainer(container);


            // Assert
            Assert.IsNotNull(result);
        }
    }
}
