using Microsoft.EntityFrameworkCore;
using TechBankAPI.Entities;

namespace TechBankAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}
