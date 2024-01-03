using JamsFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JamsFinal.Data
{
    public class JamsContext : IdentityDbContext
    {
        public JamsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}