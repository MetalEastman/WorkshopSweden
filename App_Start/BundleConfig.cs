using System.Web;
using System.Web.Optimization;

namespace WebSiteProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/WorkshopSweden.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/MyFontsWebfontsKit.css",
                      "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/css/Font-Awesome").Include(
            //        "~/Content/Font-Awesome/css/font-awesome.min.css",
            //        "~/Content/Font-Awesome/fonts/fontawesome-webfont.ttf",
            //        "~/Content/Font-Awesome/fonts/fontawesome-webfont.woff",
            //        "~/Content/Font-Awesome/fonts/fontawesome-webfont.woff2",
            //        "~/Content/Font-Awesome/css/font-awesome.css"));
        }
    }
}
