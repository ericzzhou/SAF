using System.Web.Mvc;

namespace SAF.Web.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Api_default",
                "Api/{controller}/{action}/{id}",
                new {controller="Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}