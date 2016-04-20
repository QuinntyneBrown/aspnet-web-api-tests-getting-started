using Owin;
using Microsoft.Owin;
using System.Web.Http;

namespace Chloe.Api.Tests
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configure(config => {
                ApiConfiguration.Install(config, app);
                app.UseWebApi(config);
            });            
        }
    }
}
