using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class UpdateSupplierWithHandphone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Handphone",
                table: "Suppliers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Handphone",
                table: "Suppliers");
        }
    }
}
