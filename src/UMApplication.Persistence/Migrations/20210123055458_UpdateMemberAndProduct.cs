using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class UpdateMemberAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HppPpn",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Hpp",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "Ppn",
                table: "Products",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountFlat",
                table: "Members",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hpp",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ppn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountFlat",
                table: "Members");

            migrationBuilder.AddColumn<decimal>(
                name: "HppPpn",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
