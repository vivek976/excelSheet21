using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication12.Migrations
{
    /// <inheritdoc />
    public partial class vivek4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deptId",
                table: "DepartmentsWithCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "roleId",
                table: "DepartmentsWithCategories",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deptId",
                table: "DepartmentsWithCategories");

            migrationBuilder.DropColumn(
                name: "roleId",
                table: "DepartmentsWithCategories");
        }
    }
}
