using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Tax.FixedOrByCountryStateZip
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Tax.FixedOrByCountryStateZip.AddTaxRate",
                 "Plugins/FixedOrByCountryStateZip/AddTaxRate",
                 new { controller = "FixedOrByCountryStateZip", action = "AddTaxRate" },
                 new[] { "Nop.Plugin.Tax.FixedOrByCountryStateZip.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
