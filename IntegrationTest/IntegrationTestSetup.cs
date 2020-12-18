using Microsoft.AspNetCore.Mvc.Testing;
using ProductService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IntegrationTest
{
    class IntegrationTestSetup
    {
        protected readonly HttpClient TestClient;
        public IntegrationTestSetup()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            TestClient = appFactory.CreateClient();
        }
    }
}
