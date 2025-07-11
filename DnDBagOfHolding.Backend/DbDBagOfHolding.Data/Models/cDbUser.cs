using System.ComponentModel.DataAnnotations.Schema;

namespace DnDBagOfHolding.Data.Models
{
    [Table("Users")]
    public class cDbUser : cDbBaseEntity
    {
        public string Username { get; set; }
    }
}
