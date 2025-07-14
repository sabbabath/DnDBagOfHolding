using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public class cDtoCharacter
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public eSize CharacterSize { get; set; }

        public long StrengthScore { get; set; }

        public IEnumerable<cDtoContainer> Containers { get; set; }
    }
}
