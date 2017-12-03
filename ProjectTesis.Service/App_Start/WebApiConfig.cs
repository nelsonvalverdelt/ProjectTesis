using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProjectTesis.Service.Formatter;
using System.Net.Http.Headers;

namespace ProjectTesis.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //Formatter Csv
            config.Formatters.Add(new CsvFormatter());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Formatter Json
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

        }
    }
}
