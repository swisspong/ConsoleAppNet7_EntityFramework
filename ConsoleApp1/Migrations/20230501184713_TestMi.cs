using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class TestMi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shop",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Employee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shop",
                table: "Employee",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Employee",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
