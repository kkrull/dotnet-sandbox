using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;

namespace WingtipToys.Models
{
  //(Re-)initializes the database with some seed data, whenever the model changes
  public class WingtipToysInitializer : DropCreateDatabaseIfModelChanges<WingtipToysContext>
  {
    protected override void Seed(WingtipToysContext context)
    {
      Debug.Write("(Re-)initializing Database");
      GenerateCategories().ForEach(x => context.Categories.Add(x));
      GenerateProducts().ForEach(x => context.Products.Add(x));
    }

    private static List<Category> GenerateCategories()
    {
      return new List<Category>() {
        //Generate ID as first 3 letters (lower-case) converted to left-padded DEC ASCII
        //so IDs stay ordered
        new Category() { Id = 097099099, Name = "Accessories" },
        new Category() { Id = 103117105, Name = "Guitars" },
        new Category() { Id = 115116114, Name = "Strings" },
      };
    }

    private static List<Product> GenerateProducts()
    {
      return new List<Product>() {
        new Product() {
          Id = 1,
          CategoryId = 115116114,
          Name = "GHS Boomers 10", 
          UnitPrice = 8
        },
        new Product() {
          Id = 2, 
          CategoryId = 103117105,
          Name = "LTD MH400-NT", 
          UnitPrice = 600
        },
        new Product() {
          Id = 3, 
          CategoryId = 097099099,
          Name = "Rocket Sauce", 
          UnitPrice = 2.25
        },
      };
    }
  }
}
