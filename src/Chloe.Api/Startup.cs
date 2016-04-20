using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Unity.WebApi;

[assembly: OwinStartup(typeof(Chloe.Api.Startup))]

namespace Chloe.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());

            GlobalConfiguration.Configure(config => ApiConfiguration.Install(config, app));
        }
    }
}
