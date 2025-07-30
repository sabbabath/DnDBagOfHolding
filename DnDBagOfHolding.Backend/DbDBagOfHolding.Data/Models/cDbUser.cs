using System.ComponentModel.DataAnnotations.Schema;
using DnDBagOfHolding.Common.Models.Dtos; // Add if not present

namespace DnDBagOfHolding.Data.Models
{
    [Table("Users")]
    public class cDbUser : cDbBaseEntity
    {
        public string Username { get; set; }

        public void UpdateFromDto(rDtoUser user)
        {
            if (user == null) return;

            Username = user.Username;
        }
    }
}
