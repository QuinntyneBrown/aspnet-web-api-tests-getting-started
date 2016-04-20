using Chloe.Api.Dtos;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owin;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Unity.WebApi;
using System.IO;

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
            //http://stackoverflow.com/questions/24779749/c-sharp-read-from-httpresponsemessage

            HttpResponseMessage response = await testServer.CreateRequest("/api/employee/get").GetAsync();

            if (response != null)
            {
                var responseValue = string.Empty;

                Task task = response.Content.ReadAsStreamAsync().ContinueWith(t =>
                {
                    var stream = t.Result;
                    using (var reader = new StreamReader(stream))
                    {
                        responseValue = reader.ReadToEnd();
                    }
                });

                task.Wait();
                
            }

            var result = await response.Content.ReadAsAsync<ICollection<EmployeeDto>>();
            Assert.AreEqual(result.Count, 1);
        }
    }
    
}
