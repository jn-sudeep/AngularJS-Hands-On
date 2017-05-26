using System.Web;
using System.Web.Optimization;

namespace AngularJS.HandsOn
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/AngularJS-Hands-On/script").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-route.js",
                        "~/app/HandsOnApp.js",
                        "~/app/HomeController.js",
                        "~/app/Grid/gridController.js",
                        "~/app/Grid/gridService.js"));

            bundles.Add(new StyleBundle("~/bundles/AngularJS-Hands-On/style").Include(
                      "~/Content/site.css",
                      "~/Content/bootstrap.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
