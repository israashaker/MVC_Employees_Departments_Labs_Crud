using System.Web;
using System.Web.Optimization;

namespace crudoperationEmpDept
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"
                         ));
            bundles.Add(new ScriptBundle("~/bundles/confirmDeleteEmp").Include("~/Scripts/siteScripts/confirmDeleteEmp.js"));
            bundles.Add(new ScriptBundle("~/bundles/confirmDeleteDept").Include("~/Scripts/siteScripts/confirmDeleteDept.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
