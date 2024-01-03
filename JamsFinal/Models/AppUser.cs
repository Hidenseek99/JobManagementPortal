using Microsoft.AspNetCore.Identity;

namespace JamsFinal.Models
{
    public class AppUser : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public IList<Job> Jobs { get; set; }
    }
}