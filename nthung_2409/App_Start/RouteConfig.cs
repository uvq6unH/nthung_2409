using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace nthung_2409
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
            routes.MapRoute(
                name: "GiaiPhuongTrinh",
                url: "phuong-trinh/{a}/{b}/{c}",
                defaults: new { controller = "Home", action = "GiaiPhuongTrinh", a = UrlParameter.Optional, b = UrlParameter.Optional, c = UrlParameter.Optional }
            );
        }
    }
}
