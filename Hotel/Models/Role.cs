using Microsoft.AspNetCore.Identity;

namespace Hotel.Models
{
    public class Role : IdentityRole
    {
        public ICollection<RoleUser> RoleUser { get; set; }
    }
}
