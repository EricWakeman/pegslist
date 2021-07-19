using System.ComponentModel.DataAnnotations;

namespace pegslist.Models
{
    public class House
    {
      [Required]
      public int Price { get; set; }    
      [Required]
      public int Bedrooms { get; set; }
      [Required]
      public int Bathrooms { get; set; }
      [Required]
      public int SquareFeet { get; set; }
    }
      
}