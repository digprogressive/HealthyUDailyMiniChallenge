using HealthyUDailyMiniChallenge.Infrastructure;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HealthyUDailyMiniChallenge
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            CustomizeConfig(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            ControllerBuilder.Current.SetControllerFactory(new HealthyUFactory());
        }
        
        public static void CustomizeConfig(HttpConfiguration config)
        {
            // Remove Xml formatters. This means when we visit an endpoint from a browser,
            // Instead of returning Xml, it will return Json.
            // More information from Dave Ward: http://jpapa.me/P4vdx6
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Configure json camelCasing per the following post: http://jpapa.me/NqC2HH
            // Here we configure it to write JSON property names with camel casing
            // without changing our server-side data model:
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();
            json.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            json.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            // Add model validation, globally
           // config.Filters.Add(new ValidationActionFilter());
        }
    }
}