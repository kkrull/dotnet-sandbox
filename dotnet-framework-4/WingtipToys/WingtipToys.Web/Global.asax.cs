using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using WingtipToys.Models;

namespace WingtipToys
{
  //Life cycle events for the whole application
  //https://learn.microsoft.com/en-us/previous-versions/aspnet/2wawkw1c(v=vs.100)
  public class Global : HttpApplication
  {
    void Application_Start(object sender, EventArgs e)
    {
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      Debug.Print("AppDomain[DataDirectory]: {0}", DataDirectory());
      InitializeDatabaseNow(new WingtipToysInitializer());
    }

    private static string DataDirectory()
    {
      return (string)AppDomain.CurrentDomain.GetData("DataDirectory");
    }

    private static void InitializeDatabaseNow(WingtipToysInitializer initializer)
    {
      Database.SetInitializer(initializer);
      var db = new WingtipToysContext();
      db.Database.Initialize(true);
      Debug.Print("ConnectionString: {0}", db.Database.Connection.ConnectionString);
    }
  }
}
