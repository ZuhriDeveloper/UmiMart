using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class UpdateMemberChangeCeilingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ceiling",
                table: "Members");

            migrationBuilder.AddColumn<decimal>(
                name: "Plafon",
                table: "Members",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plafon",
                table: "Members");

            migrationBuilder.AddColumn<decimal>(
                name: "Ceiling",
                table: "Members",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
