using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class AddSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_AddressInfos_AddressInfoId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_AddressInfoId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "AddressInfoId",
                table: "Suppliers");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressInfoId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddressInfoId",
                table: "Suppliers",
                column: "AddressInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_AddressInfos_AddressInfoId",
                table: "Suppliers",
                column: "AddressInfoId",
                principalTable: "AddressInfos",
                principalColumn: "AddressInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
