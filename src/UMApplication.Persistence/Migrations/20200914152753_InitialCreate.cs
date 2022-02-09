using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressInfos",
                columns: table => new
                {
                    AddressInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    SubDistrict = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInfos", x => x.AddressInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    FullName = table.Column<string>(maxLength: 60, nullable: false),
                    MembershipNumber = table.Column<string>(maxLength: 30, nullable: true),
                    CardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 60, nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 30, nullable: true),
                    AddressInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Members_AddressInfos_AddressInfoId",
                        column: x => x.AddressInfoId,
                        principalTable: "AddressInfos",
                        principalColumn: "AddressInfoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_AddressInfoId",
                table: "Members",
                column: "AddressInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "AddressInfos");
        }
    }
}
