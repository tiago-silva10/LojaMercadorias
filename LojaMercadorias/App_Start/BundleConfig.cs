using System.Web;
using System.Web.Optimization;

namespace LojaMercadorias
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle estilos = new StyleBundle("~/bundles/estilos");
            estilos.Include("~/Content/bootstrap/css/bootstrap.css");
            estilos.Include("~/Content/bootstrap/css/bootstrap.min.css");
            estilos.Include("~/Content/Site.css");
            bundles.Add(estilos);

            ScriptBundle scripts = new ScriptBundle("~/bundles/scripts");
            scripts.Include("~/Scripts/jquery.validate.unobtrusive.js");
            scripts.Include("~/Scripts/jquery-3.0.0.js");
            scripts.Include("~/Scripts/bootstrap.min.js");
            scripts.Include("~/Scripts/jquery.validate.js");
            bundles.Add(scripts);
        }
    }
}