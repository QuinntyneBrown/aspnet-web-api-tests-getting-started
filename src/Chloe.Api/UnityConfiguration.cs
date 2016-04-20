using Chloe.Api.Data;
using Chloe.Api.Data.Contracts;
using Chloe.Api.Services;
using Chloe.Api.Services.Contracts;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Chloe.Api
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IChloeUow, ChloeUow>();
            container.RegisterType<IDbContext, ChloeContext>();
            container.RegisterType<IRepositoryProvider, RepositoryProvider>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            return container;
        }
    }
}