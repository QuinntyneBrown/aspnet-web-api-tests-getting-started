using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chloe.Api.Controllers;
using System.Web.Http.Results;

namespace Chloe.Api.Tests
{
    [TestClass]
    public class TestEmployeeController
    {
        [TestMethod]
        public void GetMethod()
        {
            var employeeController = new EmployeeController();
            var result = employeeController.Get();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }
    }
}
