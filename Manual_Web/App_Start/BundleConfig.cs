using System.Web;
using System.Web.Optimization;

namespace Manual_Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", 
                        "~/Scripts/SkillHunt_js/jquery-migrate-3.0.1.min.js",
                        "~/Scripts/SkillHunt_js/popper.min.js",
                        "~/Scripts/SkillHunt_js/bootstrap.min.js",
                        "~/Scripts/SkillHunt_js/jquery.easing.1.3.js",
                        "~/Scripts/SkillHunt_js/jquery.waypoints.min.js",
                        "~/Scripts/SkillHunt_js/jquery.stellar.min.js",
                        "~/Scripts/SkillHunt_js/owl.carousel.min.js",
                        "~/Scripts/SkillHunt_js/jquery.magnific-popup.min.js",
                        "~/Scripts/SkillHunt_js/aos.js",
                        "~/Scripts/SkillHunt_js/jquery.animateNumber.min.js",
                        "~/Scripts/SkillHunt_js/scrollax.min.js",
                        "~/Scripts/SkillHunt_js/main.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/SkillHunt_css/open-iconic-bootstrap.min.css",
                      "~/Content/SkillHunt_css/animate.css",
                      "~/Content/SkillHunt_css/owl.carousel.min.css",
                      "~/Content/SkillHunt_css/owl.theme.default.min.css",
                      "~/Content/SkillHunt_css/aos.css",
                      "~/Content/SkillHunt_css/ionicons.min.css",
                      "~/Content/SkillHunt_css/bootstrap-datepicker.css",
                      "~/Content/SkillHunt_css/jquery.timepicker.css",
                      "~/Content/SkillHunt_css/flaticon.css",
                      "~/Content/SkillHunt_css/icomoon.css",
                      "~/Content/SkillHunt_css/style.css",
                      "~/Content/essence_css/core-style.css",
                      "~/Content/essence_css/style.css"));
        }
    }
}