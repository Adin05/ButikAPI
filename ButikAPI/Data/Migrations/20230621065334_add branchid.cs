using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ButikAPI.Data.Migrations
{
    public partial class addbranchid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Employees");
        }
    }
}
