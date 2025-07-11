using DnDBagOfHolding.Common.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("Items")]
    public class cDbItem : cDbBaseEntity
    {
        public string Name { get; set; }

        public decimal Weight { get; set; }

        public eSize Size { get; set; }
    }
}
