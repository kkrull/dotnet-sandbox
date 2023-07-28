using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
  //(Re-)initializes the database with some seed data, whenever the model changes
  public class WingtipToysInitializer : DropCreateDatabaseIfModelChanges<WingtipToysContext>
  {
    protected override void Seed(WingtipToysContext context)
    {
      GenerateCategories().ForEach(x => context.Categories.Add(x));
      GenerateProducts().ForEach(x => context.Products.Add(x));
    }

    private static List<Category> GenerateCategories()
    {
      return new List<Category>() {
        new Category() { Name = "Accessories" },
        new Category() { Name = "Guitars" },
        new Category() { Name = "Strings" },
      };
    }

    private static List<Product> GenerateProducts()
    {
      return new List<Product>() {
        new Product() { Name = "LTD MH400-NT", UnitPrice = 600 },
        new Product() { Name = "GHS Boomers 10", UnitPrice = 8 },
        new Product() { Name = "Rocket Sauce", UnitPrice = 2.25 },
      };
    }
  }
}
