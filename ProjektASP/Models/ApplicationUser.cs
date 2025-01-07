using Microsoft.AspNetCore.Identity;

namespace ProjektASP.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Możesz dodać tutaj własne pola, np.:
        public string FullName { get; set; }
    }
}
