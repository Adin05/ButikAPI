using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ButikAPI.Data.Migrations
{
    public partial class addbranchId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "Customers",
                newName: "RegisteredDate");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "RegisteredDate",
                table: "Customers",
                newName: "dateTime");
        }
    }
}
