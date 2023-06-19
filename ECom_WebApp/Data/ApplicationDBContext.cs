using ECom_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECom_WebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
            public DbSet<Category> Categories{ get; set; }
    }
}
