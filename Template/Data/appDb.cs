using Template.Models;
using Microsoft.EntityFrameworkCore;

namespace Template.Data
{
    public class appDb : DbContext
    {
        public appDb(DbContextOptions<appDb> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }


    }
}
