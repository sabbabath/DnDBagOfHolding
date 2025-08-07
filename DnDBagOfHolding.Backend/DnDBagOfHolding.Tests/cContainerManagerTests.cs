using DnDBagOfHolding.Business.Managers;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Tests.Utils;
using MapsterMapper;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DnDBagOfHolding.Tests
{
    [TestClass]
    public class cContainerManagerTests
    {

        [TestMethod]
        public async Task Inserting_Data_To_DatabaseAsync()
        {
            // TODO: I don't think I'm connected to the right database. Double check.
            
            // Arrange
            var dbContext = new cDbContext();
            var mapper = new Mapper();
            var mContainerManager = new cContainerManager(dbContext, mapper);
            var container = new cMockContainer();

            // Act
            var result = await mContainerManager.CreateContainer(container.ToDto());

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
