﻿using System.Web;
using System.Web.Optimization;

namespace Vidly
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js",
						"~/Scripts/DataTables/jquery.dataTables.js",
						"~/Scripts/DataTables/dataTables.bootstrap.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/bootbox.js"));

//			bundles.Add(new ScriptBundle("~/bundles/my-vanilla-js").Include(
//				"~/Scripts/my-vanilla-js/customer-validation.js",
//				"~/Scripts/my-vanilla-js/customer-delete.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap-darkly.css",
					  "~/Content/Site.css",
					  "~/Content/MyStyle.css",
					  "~/Content/DataTables/css/dataTables.bootstrap.css"));
		}
	}
}
