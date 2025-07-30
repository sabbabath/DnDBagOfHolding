using DnDBagOfHolding.Common.Models.Dtos;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("Containers")]
    public class cDbContainer : cDbBaseEntity
    {
        public long ContainerTypeId { get; set; }

        public cDbContainerType ContainerType { get; set; }

        public long CurrentWeight { get; set; }

        public void UpdateFromDto(rDtoContainer container)
        {
            if (container == null) return;

            ContainerTypeId = container.ContainerTypeId;

            CurrentWeight = container.CurrentWeight;
        }
    }
}
