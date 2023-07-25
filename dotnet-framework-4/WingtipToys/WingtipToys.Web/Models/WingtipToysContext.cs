using System.Data.Entity;

namespace WingtipToys.Models
{
  public class WingtipToysContext : DbContext
  {
    // Your context has been configured to use a 'WingtipToysContext' connection string from your application's 
    // configuration file (App.config or Web.config). By default, this connection string targets the 
    // 'WingtipToys.Models.WingtipToysContext' database on your LocalDb instance. 
    // 
    // If you wish to target a different database and/or database provider, modify the 'WingtipToysContext' 
    // connection string in the application configuration file.
    public WingtipToysContext()
        : base("name=WingtipToysContext")
    {
    }

    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
    public virtual DbSet<Product> Products { get; set; }
  }
}
