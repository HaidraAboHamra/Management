using Microsoft.EntityFrameworkCore;
using Test1.Models.Entity;

namespace Test1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Claim> Claims { get; set; }
    }
}
