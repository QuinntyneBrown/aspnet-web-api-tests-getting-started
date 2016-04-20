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

            return container;
        }
    }
}