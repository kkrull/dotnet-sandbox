using System.Data.Entity;

namespace WingtipToys.Models
{
  //The object you use to interact with the database via Entity Framework (Code First)
  //http://go.microsoft.com/fwlink/?LinkId=390109
  public class WingtipToysContext : DbContext
  {
    //Name must match the name of a connection string in [App,Web].config, or there will be weeping and gnashing of teeth
    public WingtipToysContext() : base("name=WingtipToysContext")
    {
    }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Products { get; set; }
  }
}
