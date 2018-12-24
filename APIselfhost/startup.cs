using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Owin;
using System.Web.Http;

namespace APIselfhost
{
    public class startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration conf = new HttpConfiguration();
            conf.Routes.MapHttpBatchRoute(
                name: "DefaultAPI", 
                routeTemplate: "api/{controller}/{action}/{id}/{name}", 
                defaults: new
                { controller = "student",
                    action = "get",
                    id = RouteParameter.Optional,
                    name = RouteParameter.Optional });
        }
        appBuilder.UseWebApi(conf);
    }
}
