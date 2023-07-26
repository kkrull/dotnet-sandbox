using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using WingtipToys.Models;

namespace WingtipToys
{
  public class Global : HttpApplication
  {
    void Application_Start(object sender, EventArgs e)
    {
      // Code that runs on application startup
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      Debug.Print("AppDomain[DataDirectory]: {0}", AppDomain.CurrentDomain.GetData("DataDirectory"));

      //Initialize the database right away, instead of lazily
      Database.SetInitializer(new WingtipToysInitializer());
      var db = new WingtipToysContext();
      db.Database.Initialize(true);
    }
  }
}
