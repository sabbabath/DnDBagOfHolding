using DnDBagOfHolding.Common.Models.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("ContainerAssignments")]
    public class cDbContainerAssignment : cDbBaseEntity
    {
        [Required]
        public long ContainerId { get; set; }

        public virtual cDbContainer Container { get; set; }

        [Required]
        public long CharacterId { get; set; }

        public virtual cDbCharacter Character { get; set; }

        public void UpdateFromDto(rDtoContainerAssignment assignment)
        {
            if (assignment == null) return;

            ContainerId = assignment.ContainerId;

            CharacterId = assignment.CharacterId;
        }
    }
}
