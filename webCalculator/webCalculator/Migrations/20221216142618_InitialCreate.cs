using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webCalculator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProdId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProdTitle = table.Column<string>(type: "TEXT", nullable: true),
                    ProdDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ProdQuantity = table.Column<int>(type: "INTEGER", nullable: true),
                    ProdBrand = table.Column<string>(type: "TEXT", nullable: true),
                    ProdCategory = table.Column<string>(type: "TEXT", nullable: true),
                    ProdPrice = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProdId);
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
