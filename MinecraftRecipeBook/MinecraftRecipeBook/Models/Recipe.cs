using System.ComponentModel.DataAnnotations;

namespace MinecraftRecipeBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public int[] Ingredients { get; set; } = new int[9];
        public int Count { get; set; } = 1;
        [Required]
        public int Result { get; set; }
        public bool Shapeless { get; set; } = false;
    }
}
