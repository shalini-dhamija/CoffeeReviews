using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeReviews.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Varieties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BeanType = table.Column<int>(type: "integer", nullable: false),
                    RegionOfOrigin = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varieties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "Id", "BeanType", "Description", "Name", "RegionOfOrigin" },
                values: new object[] { -1, 0, "Gesha coffee, sometimes referred to as Geisha coffee, is a variety of coffee tree that originated in the Gori Gesha forest, Ethiopia, though it is now grown in several other nations in Africa, Asia, and the Americas. It is widely known for its unique flavor profile of floral and sweet notes, its high selling price, and its exclusivity as its demand has increased over the years.", "Geisha", "Ethiopia" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Varieties");
        }
    }
}
