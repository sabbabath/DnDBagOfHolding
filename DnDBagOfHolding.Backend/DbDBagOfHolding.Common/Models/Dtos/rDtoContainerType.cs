namespace DnDBagOfHolding.Common.Models.Dtos
{
    public record rDtoContainerType(
        long Id,
        string Name,
        long WeightCapacity,
        long ItemCapacity,
        bool IsMagical,
        long Value);
}
