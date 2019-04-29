using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalService.Web.Data.Migrations
{
    public partial class AddsCodeToServiceItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "ServiceItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "ServiceItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ServiceItems",
                maxLength: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "ServiceItems");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "ServiceItems",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "ServiceItems",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
