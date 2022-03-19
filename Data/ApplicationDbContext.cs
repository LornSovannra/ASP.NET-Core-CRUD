using Book_MGS.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_MGS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } 
    }
}
