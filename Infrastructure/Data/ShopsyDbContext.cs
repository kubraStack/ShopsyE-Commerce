using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    // DbContext establishes the bridge between the database and the application
    // It represents the database session and allows us to query save data.
    public class ShopsyDbContext : DbContext
    {
       // This constructor allows us to obtain the DbContextOptions from outside(from the API layer)
       // This way, we can manage configurations such as the database connection string from a central location(Dependency Injection).

        public ShopsyDbContext(DbContextOptions<ShopsyDbContext> options) : base(options)
        {
        }

        // It specifies that a table named "Products" will be created in the database and that table will match the Product entity.
        public DbSet<Product> Products { get; set; }

        //This method allows EF Core to apply configurations when creating the models(entities and relationships.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //This line automatically finds and applies entity configurations (implementing the IEntityTypeConfiguration<T> interface) from the current assembly (this project). As the project grows, this method is very useful for keeping entity configurations in seperate files.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
