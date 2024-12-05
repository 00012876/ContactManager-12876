using System.ComponentModel.DataAnnotations;

namespace ContactManager12876.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required]
        public string Name { get; set; } = null!;
    }
}
//00012876