using basicModel.Models;
using Microsoft.EntityFrameworkCore;

namespace basicModel.Data
{
    public class appDb : DbContext
    {
        public appDb(DbContextOptions<appDb> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product_Type> product_types { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product> products { get; set; }



    }
}
