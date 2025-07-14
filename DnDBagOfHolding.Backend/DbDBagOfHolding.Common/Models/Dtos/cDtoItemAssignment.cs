namespace DnDBagOfHolding.Common.Models.Dtos
{
    public class cDtoItemAssignment
    {
        public long Id { get; set; }

        public long ItemId { get; set; }

        public long ContainerId { get; set; }

        public long CharacterId { get; set; }

        public int Quantity { get; set; }
    }
}
