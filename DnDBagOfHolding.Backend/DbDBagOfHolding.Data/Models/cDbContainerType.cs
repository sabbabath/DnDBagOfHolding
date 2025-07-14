using System.ComponentModel.DataAnnotations.Schema;
using DnDBagOfHolding.Common.Models.Dtos; // Add this if not present

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

        public void UpdateFromDto(cDtoContainerType containerType)
        {
            if (containerType == null) return;

            Name = containerType.Name;
            WeightCapacity = containerType.WeightCapacity;
            ItemCapacity = containerType.ItemCapacity;
            IsMagical = containerType.IsMagical;
            Value = containerType.Value;
        }
    }
}
