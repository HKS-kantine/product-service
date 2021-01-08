﻿using System;
using System.Data.Entity;
using System.Linq;

namespace ProductData
{
    public class CollectionAdminContext : DbContext
    {
        // Your context has been configured to use a 'Database' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CollectionData.Database' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Database' 
        // connection string in the application configuration file.
        private const string connectionString = "Server=(localdb)\\mssqllocaldb; Database=CantineDatabase; Integrated Security=SSPI; MultipleActiveResultSets=true;";
        private const string connectionStringProd = "Data Source=85.214.165.15;Initial Catalog=MaartenDB;Persist Security Info=True;User ID=Maarten;Password=Maarten";
        public CollectionAdminContext(): base(connectionStringProd)
        {

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ProductEntities.ProductDTO> Products { get; set; }


    }
}
