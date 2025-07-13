using System.ComponentModel.DataAnnotations;

namespace DnDBagOfHolding.Data.Models
{
    public class cDbBaseEntity
    {
        [Required]
        [Key]
        public long Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
