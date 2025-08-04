using DnDBagOfHolding.Common.Models.Dtos;

namespace DnDBagOfHolding.Tests.Utils
{
    public record rMockContainer : rDtoContainer
    {
        public rMockContainer(long Id = 0, long ContainerTypeId = 0, rDtoContainerType ContainerType = null, long CurrentWeight = 0, IEnumerable<rDtoItem> Items = null) : base(Id, ContainerTypeId, ContainerType, CurrentWeight, Items)
        {
            this.Id = Id == 0 ? cNextID.NextId() : Id;
            this.ContainerTypeId = ContainerTypeId == 0 ? cNextID.NextId() : ContainerTypeId;
            this.ContainerType = ContainerType;
            this.CurrentWeight = CurrentWeight;
            this.Items = Items ?? [];
        }
    }
}
