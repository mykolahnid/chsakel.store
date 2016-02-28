using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Store.Data;

namespace Store.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Init database
            Database.SetInitializer(new StoreSeedData());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
