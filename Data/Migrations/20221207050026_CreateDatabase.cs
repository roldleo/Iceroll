using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IceRoll.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Delicious chocolate that melts in the mouth", "chocoa.jpeg", "Chocoa Ice.Roll", 24.000m },
                    { 2, "delicious bananas with unrivaled tenderness", "banana.jpeg", "Banana Ice.Roll", 22.000m },
                    { 3, "very tempting fragrance with fresh fruit", "manggo.jpeg", "Mango Ice.Roll", 26.000m },
                    { 4, "so tempting sweet with delicious taste", "orange.jpeg", "orange Ice.Roll", 23.000m },
                    { 5, "So delicious crunchy", "oreo.jpeg", "Oreo Ice.Roll", 28.000m },
                    { 6, "delicious taste with fresh fruit topping", "strawberry.jpeg", "Strawberry Ice.Roll", 26.000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
