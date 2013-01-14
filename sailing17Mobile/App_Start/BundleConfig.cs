using System.Web;
using System.Web.Optimization;

namespace sailing17Mobile
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;  
            
            //script script/main
            bundles.Add(new ScriptBundle("~/script/basejs").Include(
                "~/script/jquery-1.8.3.min.js"
            ));

            //style css/main
            //bundles.Add(new StyleBundle("~/res/css/basecss").Include(
            //    "~/res/css/style.css"
            //));

        }
    }
}