using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace odata_demo_new
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.MapRestierRoute<EntityFrameworkApi<Serene2_Northwind_v1Entities>>(
               "Northwind",
               "api/NorthwindLT",
               new RestierBatchHandler(GlobalConfiguration.DefaultServer)).Wait();

            config.MapRestierRoute<EntityFrameworkApi<Serene2_Default_v1Entities>>(
               "Default",
               "api/DefaultLT",
               new RestierBatchHandler(GlobalConfiguration.DefaultServer)).Wait();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
