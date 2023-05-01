using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Employee_Add_Shop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shop",
                table: "Employee",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shop",
                table: "Employee");
        }
    }
}
