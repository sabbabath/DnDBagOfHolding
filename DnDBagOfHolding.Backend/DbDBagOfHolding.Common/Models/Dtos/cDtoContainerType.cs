using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public class cDtoContainerType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public long WeightCapacity { get; set; }

        public long ItemCapacity { get; set; }

        public bool IsMagical { get; set; }

        public long Value { get; set; }
    }
}
