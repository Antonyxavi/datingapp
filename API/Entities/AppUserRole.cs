using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public Appuser User { get; set; }

        public AppRole Role { get; set; }
    }
}