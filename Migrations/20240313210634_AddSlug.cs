using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeReviews.Migrations
{
    /// <inheritdoc />
    public partial class AddSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Varieties",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: -1,
                column: "Slug",
                value: "geisha");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Varieties");
        }
    }
}
