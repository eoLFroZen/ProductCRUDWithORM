using Microsoft.EntityFrameworkCore;
using Product_With_ORM.Data.Entities;

namespace Product_With_ORM.Data
{
    public class ProductDbContext : DbContext
    {
        private const string ConnectionString = "Server=localhost;Database=product_db_orm;Uid=root;Pwd=1234;";

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(ConnectionString);
        }
    }
}
