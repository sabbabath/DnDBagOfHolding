using DnDBagOfHolding.Business.Interfaces;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Tests.Utils;
using Moq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DnDBagOfHolding.Tests
{
    [TestClass]
    public class cContainerManagerTests
    {

        [TestMethod]
        public async Task Inserting_Data_To_DatabaseAsync()
        {
            // Arrange
            Mock<iContainerManager> mContainerManager = new();
            
            var containerManager = mContainerManager.Object;
            var dbContext = new Mock<cDbContext>();
            var container = new cMockContainer();

            // Act
            var result = await containerManager.CreateContainer(container);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
