using System.Web;
using System.Web.Routing;

namespace Services.Logging.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
