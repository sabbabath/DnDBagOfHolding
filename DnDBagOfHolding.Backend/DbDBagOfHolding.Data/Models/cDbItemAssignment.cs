using System.ComponentModel.DataAnnotations.Schema;
using DnDBagOfHolding.Common.Models.Dtos; // Add if not present

namespace DnDBagOfHolding.Data.Models
{
    [Table("ItemAssignments")]
    public class cDbItemAssignment : cDbBaseEntity
    {
        public long ItemId { get; set; }

        public long ContainerId { get; set; }

        public long CharacterId { get; set; }

        public int Quantity { get; set; }

        public void UpdateFromDto(cDtoItemAssignment assignment)
        {
            if (assignment == null) return;

            ItemId = assignment.ItemId;
            ContainerId = assignment.ContainerId;
            CharacterId = assignment.CharacterId;
            Quantity = assignment.Quantity;
        }
    }
}
