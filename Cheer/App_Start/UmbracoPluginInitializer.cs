using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using WebActivatorEx;
using Cheer.App_Start;

[assembly: PostApplicationStartMethod(typeof(UmbracoPluginInitializer), "PostApplicationStart")]
namespace Cheer.App_Start
{
    public static class UmbracoPluginInitializer
    {
        /// 
        /// Runs right after the application has initialized.
        /// 
        public static void PostApplicationStart()
        {
            // Run bundle optimizer.
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}