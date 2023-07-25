using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace WingtipToys.Models
{
  public class WingtipsContext : DbContext
  {
    // Your context has been configured to use a 'WingtipsContext' connection string from your application's 
    // configuration file (App.config or Web.config). By default, this connection string targets the 
    // 'WingtipToys.Models.WingtipsContext' database on your LocalDb instance. 
    // 
    // If you wish to target a different database and/or database provider, modify the 'WingtipsContext' 
    // connection string in the application configuration file.
    public WingtipsContext()
        : base("name=WingtipsContext")
    {
    }

    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
    public virtual DbSet<Product> Products { get; set; }
  }

  public class Product
  {
    [ScaffoldColumn(false)]
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; }

    [Display(Name="Price")]
    public double? UnitPrice { get; set; }
  }
}
