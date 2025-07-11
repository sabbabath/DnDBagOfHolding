using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("ContainerTypes")]
    public class cDbContainerType : cDbBaseEntity
    {
        public string Name { get; set; }

        public long WeightCapacity { get; set; }

        public long ItemCapacity { get; set; }

        public bool IsMagical { get; set; }

        public long Value { get; set; }
    }
}
