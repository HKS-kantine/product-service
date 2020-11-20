using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductData
{
    public class CollectionAdminContext : DbContext
    {
        private const string connectionString = "Server=localhost, 1400; Database=CollectionAdminDatabase; User Id=sa;Password=G4sLOj7P; MultipleActiveResultSets=true;";
        private const string connectionStringDocker = "Server=db-server; Database=CollectionAdminDatabase; User Id=sa;Password=G4sLOj7P; MultipleActiveResultSets=true;";
        public CollectionAdminContext()
            : base()
        {
        }
        public virtual DbSet<ProductEntities.ProductDTO> Products { get; set; }
    }
}
