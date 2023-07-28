using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
  //A group of related products
  public class Category
  {
    [ScaffoldColumn((false))]
    public int Id { get; set; }
    
    [Required, StringLength(100)]
    public string Name { get; set; }
  }
}
