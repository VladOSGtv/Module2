using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Module_2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Маршруты для других контроллеров

            routes.MapRoute(
                name: "Employee",
                url: "Employee/{action}/{id}",
                defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Position",
                url: "Position/{action}/{id}",
                defaults: new { controller = "Position", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Allowance",
                url: "Allowance/{action}/{id}",
                defaults: new { controller = "Allowance", action = "Index", id = UrlParameter.Optional }
            );
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
