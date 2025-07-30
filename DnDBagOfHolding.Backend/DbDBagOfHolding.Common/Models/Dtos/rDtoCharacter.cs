using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public record struct rDtoCharacter(
        long Id, 
        long UserId, 
        string Name, 
        eSize CharacterSize, 
        long StrengthScore, 
        IEnumerable<rDtoContainer> Containers);
}
