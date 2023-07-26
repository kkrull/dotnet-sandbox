using System;
using System.Linq;
using System.IO;
using WingtipToys.Models;

namespace Wingtip.Cli
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //TODO KDK: Point this to the App_Data used by Web, instead of trying ot re-configure Web
      var baseDirectory = AppDomain.CurrentDomain.BaseDirectory; //<solution>/cli/bin/debug
      Console.WriteLine("Base directory: {0}", baseDirectory);

      var assemblyUri = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));
      var assemblyDirectory = assemblyUri.LocalPath;
      Console.WriteLine("Assembly directory: {0}", assemblyDirectory);

      var assemblyDirectoryInfo = new DirectoryInfo(assemblyDirectory);
      var solutionDirectory = assemblyDirectoryInfo.Parent.Parent.Parent;
      Console.WriteLine("Solution directory: {0}", solutionDirectory.FullName);

      var dataDirectory = Path.Combine(solutionDirectory.FullName, "Data");
      Console.WriteLine("Data directory: {0}", dataDirectory);


      Directory.CreateDirectory(dataDirectory);
      AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
      Console.WriteLine("AppDomain DataDirectory: {0}", AppDomain.CurrentDomain.GetData("DataDirectory"));

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
