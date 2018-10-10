using System.Web.Http;

namespace DistributedServices.MainBoundedContext.Api.App_Start
{
    public class WebApiConfig
    {
        public static string ControllerOnly = "ApiControllerOnly";
        public static string ControllerAndId = "ApiControllerAndGuiid";
        public static string ControllerAction = "ApiControllerAction";
        public static string ControllerActionAndId = "ApiControllerActionAndGuid";

        public const string GuidPattern =
            @"^[A-Za-z0-9]{8}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{4}-[A-Za-z0-9]{12}$";

        public static void Configure(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: ControllerOnly,
                routeTemplate: "api/{controller}"
            );

            config.Routes.MapHttpRoute(
                name: ControllerAndId,
                routeTemplate: "api/{controller}/{id}",
                defaults: null, //defaults: new { id = RouteParameter.Optional } //,
                constraints: new { id = GuidPattern } // id must be all digits
            );

            config.Routes.MapHttpRoute(
                name: ControllerAction,
                routeTemplate: "api/{controller}/{action}"
            );

            config.Routes.MapHttpRoute(
                name: ControllerActionAndId,
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: null, //defaults: new { id = RouteParameter.Optional } //,
                constraints: new { id = GuidPattern } // id must be all digits
            );
        }
    }
}