using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public class cDtoContainer
    {
        public Guid Id { get; set; }

        public long ContainerTypeId { get; set; }

        public cDtoContainerType ContainerType { get; set; }

        public long CurrentWeight { get; set; }

        public IEnumerable<cDtoItem> Items { get; set; }
    }
}
