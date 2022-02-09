using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class UpdateTableMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_AddressInfos_AddressInfoId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_AddressInfoId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "AddressInfoId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "KtpNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Members");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressInfoId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Members",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Members",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KtpNumber",
                table: "Members",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Members",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_AddressInfoId",
                table: "Members",
                column: "AddressInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_AddressInfos_AddressInfoId",
                table: "Members",
                column: "AddressInfoId",
                principalTable: "AddressInfos",
                principalColumn: "AddressInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
