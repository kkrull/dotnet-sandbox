using System;
using System.Linq;
using System.IO;
using WingtipToys.Models;
using System.Collections.Generic;
using System.Reflection;

namespace Wingtip.Cli
{
  public class Program
  {
    public static void Main(string[] args)
    {
      UseDataDirectory(AppDataDirectory());
      using (var db = new WingtipToysContext()) {
        ListProducts(db.Products.OrderBy(x => x.Name));
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }

    /* Application configuration */

    private static string AppDataDirectory()
    {
      var appDirectory = AppDirectory();
      var dataDirectory = Path.Combine(appDirectory.FullName, "WingtipToys.Web", "App_Data");
      return dataDirectory;
    }

    private static DirectoryInfo AppDirectory()
    {
      var cliAssemblyCodebase = Assembly.GetExecutingAssembly().GetName().CodeBase;
      var cliAssemblyUri = new Uri(Path.GetDirectoryName(cliAssemblyCodebase));
      var assemblyDirectoryInfo = new DirectoryInfo(cliAssemblyUri.LocalPath); //<solution>/WingtipToys.Cli/Bin/Debug
      return assemblyDirectoryInfo.Parent.Parent.Parent;
    }

    private static void UseDataDirectory(string dataDirectory)
    {
      Directory.CreateDirectory(dataDirectory);
      AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
    }

    /* Application data */

    private static void ListProducts(IEnumerable<Product> products)
    {
      Console.WriteLine("==Products==");
      foreach (var product in products) {
        Console.WriteLine("- {0}", product.Name);
      }
    }
  }
}
