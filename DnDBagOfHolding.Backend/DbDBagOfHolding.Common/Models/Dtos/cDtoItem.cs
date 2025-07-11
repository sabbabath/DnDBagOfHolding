using DnDBagOfHolding.Common.Models.Enums;

namespace DnDBagOfHolding.Common.Models.Dtos
{
    public class cDtoItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Weight { get; set; }

        public eSize Size { get; set; }
    }
}
