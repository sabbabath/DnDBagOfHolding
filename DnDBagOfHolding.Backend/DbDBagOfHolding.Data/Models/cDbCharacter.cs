using DnDBagOfHolding.Common.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("Characters")]
    public class cDbCharacter : cDbBaseEntity
    {
        public string Name { get; set; }

        public eSize CharacterSize { get; set; }

        public long StrengthScore { get; set; }
    }
}
