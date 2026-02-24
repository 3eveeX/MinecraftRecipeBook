namespace MinecraftRecipeBook.Models
{
    public class Recipe
    {
        private static int nextId = 0;
        private readonly int id = nextId++;
        public int Id { get { return id; } }
        public int[] Ingredients { get; set; } = new int[9];
        public int Count { get; set; } = 1;
        public int Result { get; set; }
        public bool Shapeless { get; set; } = false;
    }
}
