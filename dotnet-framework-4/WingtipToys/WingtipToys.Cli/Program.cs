using System;
using System.Linq;
using WingtipToys.Models;

namespace Wingtip.Cli
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("==Products==");
      using (var db = new WingtipToysContext()) {
        var products = db.Products.OrderBy(x => x.Name);
        foreach (var product in products) {
          Console.WriteLine("- {0}", product.Name);
        }
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
