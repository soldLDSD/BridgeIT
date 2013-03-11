using System.Web.Optimization;

namespace ResponsiveLayout
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{
			// Force optimization to be on or off, regardless of web.config setting
			//BundleTable.EnableOptimizations = false;
			bundles.UseCdn = false;

			// .debug.js, -vsdoc.js and .intellisense.js files 
			// are in BundleTable.Bundles.IgnoreList by default.
			// Clear out the list and add back the ones we want to ignore.
			// Don't add back .debug.js.
			bundles.IgnoreList.Clear();
			bundles.IgnoreList.Ignore("*-vsdoc.js");
			bundles.IgnoreList.Ignore("*intellisense.js");

			// Modernizr goes separate since it loads first
			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr")
				.Include("~/Scripts/modernizr-{version}.js"));

			// jQuery

			// 3rd Party JavaScript files

			// All application JS files (except mocks)

			// 3rd Party CSS files
			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/normalize.css",
				"~/Content/lessstyles.less"));

			// Custom LESS files
		}
	}
}