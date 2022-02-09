using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class AddStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockIns",
                columns: table => new
                {
                    StockInId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 60, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 60, nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    InputDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIns", x => x.StockInId);
                    table.ForeignKey(
                        name: "FK_StockIns_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockIns_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 60, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 60, nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 3, nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    InputDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockIns_ProductId",
                table: "StockIns",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockIns_SupplierId",
                table: "StockIns",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockIns");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
