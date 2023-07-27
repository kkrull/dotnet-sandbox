using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace WingtipToys
{
  //Oh the wonderful places you can go (with a URL, in this web application)
  public static class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.EnableFriendlyUrls(new FriendlyUrlSettings {
        AutoRedirectMode = RedirectMode.Permanent
      });
    }
  }
}
