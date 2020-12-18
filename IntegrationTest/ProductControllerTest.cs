using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace IntegrationTest
{
    class Tests: IntegrationTestSetup
    {
        private string baseUrl = "api/product";

        [Test]
        public async Task Get_Test()
        {
            var response = await TestClient.GetAsync(baseUrl);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}