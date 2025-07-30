using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public record rDtoContainer(
        long Id,
        long ContainerTypeId,
        rDtoContainerType ContainerType,
        long CurrentWeight,
        IEnumerable<rDtoItem> Items);
}
