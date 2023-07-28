using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
  //Something listed for sale
  public class Product
  {
    [ScaffoldColumn(false)] public int Id { get; set; }
    
    //TODO KDK: Make this required
    public int? CategoryId { get; set; }

    [Required, StringLength(100)] public string Name { get; set; }

    [Display(Name = "Price"), Required] public double? UnitPrice { get; set; }
  }
}
