using System.ComponentModel.DataAnnotations;

namespace MinecraftRecipeBook.Models
{
    public class Item
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? ImagePath { get; set; }
    }
}
