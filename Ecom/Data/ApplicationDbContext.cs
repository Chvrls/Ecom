using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ecom.Models;

namespace Ecom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ecom.Models.Shop> Shop { get; set; } = default!;
        public DbSet<Ecom.Models.Review> Review { get; set; } = default!;
    }
}
