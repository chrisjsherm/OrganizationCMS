using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Cheer.App_Start
{
    public class BundleConfig
    {
       
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            bundles.Add(
                new StyleBundle("~/css/app")
                  .Include("~/css/app.css")
            );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/scripts/modernizrlib").Include(
                        "~/scripts/modernizr/modernizr.js"));

            bundles.Add(
                new ScriptBundle("~/scripts/vendor")
                  .Include("~/scripts/jquery/dist/jquery.js")
                  .Include("~/scripts/fastclick/lib/fastclick.js")
                  .Include("~/scripts/foundation/js/foundation/foundation.js")
                  .Include("~/scripts/foundation/js/foundation/foundation.abide.js")
                  .Include("~/scripts/foundation/js/foundation/foundation.clearing.js")
                  .Include("~/scripts/foundation/js/foundation/foundation.interchange.js")
                  .Include("~/scripts/foundation/js/foundation/foundation.topbar.js")
                  .Include("~/scripts/app.js")
            );

        }

        private static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
            {
                throw new ArgumentNullException("BundleConfig ignore list.");
            }

            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
        }
    }
}