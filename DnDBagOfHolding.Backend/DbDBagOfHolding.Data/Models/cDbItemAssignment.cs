using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("ItemAssignments")]
    public class cDbItemAssignment : cDbBaseEntity
    {
        public Guid ItemId { get; set; }

        public Guid ContainerId { get; set; }

        public Guid CharacterId { get; set; }

        public int Quantity { get; set; }
    }
}
