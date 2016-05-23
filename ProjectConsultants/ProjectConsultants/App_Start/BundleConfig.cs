using System.Web.Optimization;

namespace ProjectConsultants.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/CustomScripts").Include("~/Scripts/CustomScripts/*.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/bundles/UserDefinedCss").Include("~/Content/CSS/site.css","~/Content/CSS/Layout.css"));

        }
    }
}