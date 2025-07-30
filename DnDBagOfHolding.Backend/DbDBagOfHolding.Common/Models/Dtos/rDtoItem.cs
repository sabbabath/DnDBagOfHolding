using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public record rDtoItem(
        long Id,
        string Name,
        decimal Weight,
        eSize Size);
}
