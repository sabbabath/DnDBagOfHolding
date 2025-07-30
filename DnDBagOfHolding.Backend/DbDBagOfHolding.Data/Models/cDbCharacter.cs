using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Common.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("Characters")]
    public class cDbCharacter : cDbBaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public cDbUser User { get; set; }

        public eSize CharacterSize { get; set; }

        public long StrengthScore { get; set; }

        public void UpdateFromDto(rDtoCharacter character)
        {
            if (character == null) return;

            Name = character.Name;

            CharacterSize = character.CharacterSize;

            StrengthScore = character.StrengthScore;
        }
    }
}
