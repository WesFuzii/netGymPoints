using System.Web;
using System.Web.Optimization;

namespace GymPoints
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {       
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/vendor/jquery/jquery-3.2.1.min.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.js",
                      "~/Content/vendor/bootstrap/js/popper.min.js",
                      "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                      "~/Content/assets/js/scrolling-nav.js",
                      "~/Content/assets/js/main.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap2").Include(
                      "~/Content/vendor/jquery/jquery-3.2.1.min.js",
                      "~/Content/vendor/bootstrap/js/popper.min.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                      "~/Content/assets/js/main.js",
                      "~/Content/assets/js/chartist.min.js",
                      "~/Content/assets/js/bootstrap-notify.js",
                      "~/Content/assets/js/light-bootstrap-dashboard.js",
                      "~/Content/assets/js/demo.js",
                      "~/Content/assets/js/compra.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",                      
                                           
                      "~/Content/assets/css/one-page-wonder.min.css",
                      "~/Content/vendor/animate/animate.css",
                      "~/Content/vendor/css-hamburgers/hamburgers.min.css",
                      "~/Content/vendor/animsition/css/animsition.min.css",
                      "~/Content/vendor/select2/select2.min.css",
                      "~/Content/assets/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/assets/fonts/iconic/css/material-design-iconic-font.min.css",
                      "~/Content/assets/css/util.css",
                      "~/Content/assets/css/main.css"));

            bundles.Add(new StyleBundle("~/Content/css2").Include(
                    "~/Content/assets/css/pe-icon-7-stroke.css",
                    "~/Content/assets/css/bootstrap.min.css",
                    "~/Content/assets/css/animate.min.css",
                    "~/Content/assets/css/light-bootstrap-dashboard.css"
                ));
        }
    }
}
