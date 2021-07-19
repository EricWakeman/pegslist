using System.ComponentModel.DataAnnotations;

namespace pegslist.Models
{
    public class Car
    {
      [Required]
      [MinLength(3)]
      public string Make {get; set;}
      [Required]
      [MinLength(3)]
      public string Model {get; set;}
      public string Color {get; set;}
      public decimal Price {get; set;}
      public int Year {get; set;}
      public int Id {get; set;}
    }
}