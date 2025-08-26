using DnDBagOfHolding.Business.Managers;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Tests.Utils;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DnDBagOfHolding.Tests
{
    [TestClass]
    public class cContainerManagerTests
    {
        private IServiceProvider serviceProvider;

        [TestInitialize]
        public void Setup()
        {
            // https://medium.com/codenx/ef-core-in-memory-database-unit-testing-02d4658a9c78
            var services = new ServiceCollection();

            services.AddDbContext<cDbContext>(options =>
            {
                options.UseInMemoryDatabase("DnDBagOfHoldingTestDb");
            });

            serviceProvider = services.BuildServiceProvider();
        }


        [TestMethod]
        public async Task Should_Create_New_Container()
        {
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

        [TestMethod]
        public async Task Should_Update_Existing_Container()
        {
            // Arrange
            var dbContext = new cDbContext();
            var mapper = new Mapper();
            var mContainerManager = new cContainerManager(dbContext, mapper);
            var container = new cMockContainer();

            // Act
            var result = await mContainerManager.UpdateContainer(container.ToDto());

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task Should_Delete_Container()
        {
            // Arrange
            var dbContext = new cDbContext();
            var mapper = new Mapper();
            var mContainerManager = new cContainerManager(dbContext, mapper);
            var container = new cMockContainer();

            // Act
            var result = await mContainerManager.GetContainer(container.Id);

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public async Task Should_Get_Container()
        {
            // Arrange
            var dbContext = new cDbContext();
            var mapper = new Mapper();
            var mContainerManager = new cContainerManager(dbContext, mapper);
            var container = new cMockContainer();

            // Act
            var result = await mContainerManager.GetContainer(container.Id);

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
