using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ex3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi1",
                routeTemplate: "api/{controller}/{mazeName}/{row}/{col}",
                defaults: new { mazeName = RouteParameter.Optional,
                                row = RouteParameter.Optional,
                                col = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
