using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data;
using DnDBagOfHolding.Data.Models;

namespace DnDBagOfHolding.Tests.Utils
{
    public class cMockContainer : cDbContainer
    {
        public cMockContainer(long Id = 0, long ContainerTypeId = 0, rDtoContainerType ContainerType = null, long CurrentWeight = 0, IEnumerable<rDtoItem> Items = null)
        {
            this.Id = Id == 0 ? cNextID.NextId() : Id;
            this.ContainerTypeId = ContainerTypeId == 0 ? cNextID.NextId() : ContainerTypeId;
            this.CurrentWeight = CurrentWeight;
        }

        public cMockContainer Save(cDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext), "Database context cannot be null.");
            }
            dbContext.Containers.Add(this);
            dbContext.SaveChanges();
            return this;
        }

        public rDtoContainer ToDto()
        {
            return new rDtoContainer(this.Id, this.ContainerTypeId, null, this.CurrentWeight, null);
        }
    }
}
