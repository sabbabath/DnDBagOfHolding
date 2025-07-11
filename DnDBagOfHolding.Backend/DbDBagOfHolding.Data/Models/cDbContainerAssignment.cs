using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("ContainerAssignments")]
    public class cDbContainerAssignment : cDbBaseEntity
    {
        [Required]
        public Guid ContainerId { get; set; }

        public virtual cDbContainer Container { get; set; }

        [Required]
        public Guid CharacterId { get; set; }

        public virtual cDbCharacter Character { get; set; }
    }
}
