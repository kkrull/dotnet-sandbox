using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using WingtipToys.Models;

namespace WingtipToys.Cli
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      UseDataDirectory(AppDataDirectory());
      using (var db = new WingtipToysContext()) {
        ListCategories(db.Categories.OrderBy(x => x.Name));
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
      return Path.Combine(appDirectory.FullName, "WingtipToys.Web", "App_Data");
    }

    private static DirectoryInfo AppDirectory()
    {
      var cliAssemblyCodebase = Assembly.GetExecutingAssembly().GetName().CodeBase;
      var cliAssemblyDirectory = Path.GetDirectoryName(cliAssemblyCodebase);
      if (cliAssemblyDirectory == null) {
        throw new ApplicationException($"Unable to determine directory containing CLI assembly: {cliAssemblyCodebase}");
      }

      var cliAssemblyUri = new Uri(cliAssemblyDirectory);
      var assemblyDirectory = new DirectoryInfo(cliAssemblyUri.LocalPath); //<solution>/WingtipToys.Cli/Bin/Debug
      return assemblyDirectory.Parent?.Parent?.Parent;
    }

    private static void UseDataDirectory(string dataDirectory)
    {
      Directory.CreateDirectory(dataDirectory);
      AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
    }

    /* Application data */

    private static void ListCategories(IEnumerable<Category> categories)
    {
      Console.WriteLine();
      Console.WriteLine("==Categories==");
      foreach (var category in categories) {
        Console.WriteLine("- {0}: {1}", category.Id, category.Name);
      }
    }

    private static void ListProducts(IEnumerable<Product> products)
    {
      Console.WriteLine();
      Console.WriteLine("==Products==");
      foreach (var product in products) {
        Console.WriteLine("- {0}: {1} (categoryId: {2})",
          product.Id, 
          product.Name,
          product.CategoryId
        );
      }
    }
  }
}
