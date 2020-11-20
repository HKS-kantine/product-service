using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductData
{
    public class CollectionAdminContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb; Database=ProductData.CollectionAdminContext; User Id=sla;Password=G4sLOj7P; MultipleActiveResultSets=true;";
        private const string connectionStringDocker = "Server=db-server; Database=ProductData.CollectionAdminContext; User Id=sa;Password=G4sLOj7P; MultipleActiveResultSets=true;";
        public CollectionAdminContext()
            : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public virtual DbSet<ProductEntities.ProductDTO> Product { get; set; }
    }
}
