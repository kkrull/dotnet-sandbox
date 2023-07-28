using System.Web.Optimization;

namespace WingtipToys
{
  //Answers the question: How did ASP.NET solve the problem of loading scripts and dependencies in the right order?
  //Spoiler: It didn't.
  public static class BundleConfig
  {
    //Bundles of JavaScript code that ASPs load via script tags by calling Scripts.Render
    //https://go.microsoft.com/fwlink/?LinkID=303951
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
        "~/Scripts/WebForms/WebForms.js",
        "~/Scripts/WebForms/WebUIValidation.js",
        "~/Scripts/WebForms/MenuStandards.js",
        "~/Scripts/WebForms/Focus.js",
        "~/Scripts/WebForms/GridView.js",
        "~/Scripts/WebForms/DetailsView.js",
        "~/Scripts/WebForms/TreeView.js",
        "~/Scripts/WebForms/WebParts.js"));

      // Order is very important for these files to work, they have explicit dependencies
      bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
        "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
        "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
        "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
        "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

      // Use the Development version of Modernizr to develop with and learn from. Then, when you’re
      // ready for production, use the build tool at https://modernizr.com to pick only the tests you need
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
        "~/Scripts/modernizr-*"));
    }
  }
}
