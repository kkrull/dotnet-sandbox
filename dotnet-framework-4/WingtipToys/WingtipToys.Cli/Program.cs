using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingtipToys.Models;

namespace Wingtip.Cli
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("==Products==");
      using (var db = new WingtipToysContext()) {
        //var aProduct = new Product { Name = "Rocket Sauce" };
        //db.Products.Add(aProduct);
        //db.SaveChanges();

        var products = from p in db.Products
                    orderby p.Name
                    select p;

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
