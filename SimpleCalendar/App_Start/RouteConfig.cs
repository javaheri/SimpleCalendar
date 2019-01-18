using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleCalendar
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
              name: "CalendarMonth",
              url: "calendar/{id}",
              defaults: new { controller = "Calendar", action = "SelectedMonth" }
          );

            routes.MapRoute(
             name: "Appointment",
             url: "appointment/{id}",
             defaults: new { controller = "Appointment", action = "Selected" }
         );

            routes.MapRoute(
                name: "Calendar",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Calendar", action = "Index", id = UrlParameter.Optional }
            );

          
        }
    }
}
