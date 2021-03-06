﻿using System.Web;
using System.Web.Optimization;

namespace WebShopCC
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
                      "~/Scripts/bootstrap-notify.js",
                      "~/Scripts/Site.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                      "~/Content/site.css"));
            

            #region WebShopCC Javascript
            bundles.Add(new ScriptBundle("~/bundles/WebShop/js").Include(
                      "~/Scripts/jquery.scrollUp.min.js",
                      "~/Scripts/price-range.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/main.js",
                      "~/Scripts/respond.js"));
            #endregion

            #region WebShopCC CSS
            bundles.Add(new StyleBundle("~/Content/WebShop/css").Include(
                      "~/Content/font-awesome.min",
                      "~/Content/prettyPhoto.css",
                      "~/Content/price-range.css",
                      "~/Content/webshop.css",
                      "~/Content/animate.css",
                      "~/Content/main.css",
                      "~/Content/responsive.css"));
            #endregion

            #region Knockout.js
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
              "~/Scripts/knockout-{version}.js",
              "~/Scripts/app.js"));
            #endregion
        }
    }
}
