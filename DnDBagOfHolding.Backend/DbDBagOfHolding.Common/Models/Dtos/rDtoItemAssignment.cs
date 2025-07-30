namespace DnDBagOfHolding.Common.Models.Dtos
{
    public record rDtoItemAssignment(
        long Id,
        long ItemId,
        long ContainerId,
        long CharacterId,
        int Quantity);
}
