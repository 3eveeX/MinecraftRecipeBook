namespace MinecraftRecipeBook.Models
{
    public class Item
    {
        private static int nextId = 0;
        private readonly int id = nextId++;
        public int Id { get { return id; } }
        public string Name { get; set; }
        public string? ImagePath { get; set; }
    }
}
