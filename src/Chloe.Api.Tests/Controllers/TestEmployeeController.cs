using Chloe.Api.Dtos;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owin;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Unity.WebApi;

namespace Chloe.Api.Tests.Controllers
{
    [TestClass]
    public class TestEmployeeController
    {
        protected TestServer testServer;

        [TestInitialize]
        public void Setup()
        {
            testServer = TestServer.Create(app =>
            {
                HttpConfiguration config = new HttpConfiguration();
                config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
                ApiConfiguration.Install(config, app);
                app.UseWebApi(config);
            });
        }

        [TestCleanup]
        public void TearDown()
        {
            if (testServer != null)
                testServer.Dispose();
        }
        
        [TestMethod]
        public async Task GetMethod()
        {
            HttpResponseMessage response = await testServer.CreateRequest("/api/employee/get").GetAsync();
            var result = await response.Content.ReadAsAsync<ICollection<EmployeeDto>>();
            Assert.AreEqual(result.Count, 1);
        }
    }
    
}
