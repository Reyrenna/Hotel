using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Hotel.Models
{
    public class Client : IdentityUser
    {
        [Key]
        public Guid IdClient { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }

        public ICollection<RoleUser> RoleUser { get; set; }

        public ICollection<Reservation> Room { get; set; }
    }
}
