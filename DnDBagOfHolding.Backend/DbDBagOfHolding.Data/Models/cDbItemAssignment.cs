using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("ItemAssignments")]
    public class cDbItemAssignment : cDbBaseEntity
    {
        public long ItemId { get; set; }

        public long ContainerId { get; set; }

        public long CharacterId { get; set; }

        public int Quantity { get; set; }
    }
}
