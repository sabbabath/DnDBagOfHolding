using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("Containers")]
    public class cDbContainer : cDbBaseEntity
    {
        public long ContainerTypeId { get; set; }

        public cDbContainerType ContainerType { get; set; }

        public long CurrentWeight { get; set; }
    }
}
