using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinecraftRecipeBook.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IngredientsRaw",
                table: "Recipes",
                newName: "Ingredients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingredients",
                table: "Recipes",
                newName: "IngredientsRaw");
        }
    }
}
