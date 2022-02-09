using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UMApplication.Persistence.Migrations
{
    public partial class SalesOrderAddPaidDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockIns_Products_ProductId",
                table: "StockIns");

            migrationBuilder.DropForeignKey(
                name: "FK_StockIns_Suppliers_SupplierId",
                table: "StockIns");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockIns",
                table: "StockIns");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stock");

            migrationBuilder.RenameTable(
                name: "StockIns",
                newName: "StockIn");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_ProductId",
                table: "Stock",
                newName: "IX_Stock_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_StockIns_SupplierId",
                table: "StockIn",
                newName: "IX_StockIn_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_StockIns_ProductId",
                table: "StockIn",
                newName: "IX_StockIn_ProductId");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidDate",
                table: "SalesOrders",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "StockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockIn",
                table: "StockIn",
                column: "StockInId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Products_ProductId",
                table: "Stock",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockIn_Products_ProductId",
                table: "StockIn",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockIn_Suppliers_SupplierId",
                table: "StockIn",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Products_ProductId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_StockIn_Products_ProductId",
                table: "StockIn");

            migrationBuilder.DropForeignKey(
                name: "FK_StockIn_Suppliers_SupplierId",
                table: "StockIn");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockIn",
                table: "StockIn");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PaidDate",
                table: "SalesOrders");

            migrationBuilder.RenameTable(
                name: "StockIn",
                newName: "StockIns");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Stocks");

            migrationBuilder.RenameIndex(
                name: "IX_StockIn_SupplierId",
                table: "StockIns",
                newName: "IX_StockIns_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_StockIn_ProductId",
                table: "StockIns",
                newName: "IX_StockIns_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_ProductId",
                table: "Stocks",
                newName: "IX_Stocks_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockIns",
                table: "StockIns",
                column: "StockInId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockIns_Products_ProductId",
                table: "StockIns",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockIns_Suppliers_SupplierId",
                table: "StockIns",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
