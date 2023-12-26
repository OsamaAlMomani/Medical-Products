using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basicModel.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_product_types_product_typeId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_brandId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_product_typeId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "brandId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "product_typeId",
                table: "products");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EXP_date",
                table: "products",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Sign_date",
                table: "products",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "custom_ID",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "product_type",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EXP_date",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Sign_date",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "products");

            migrationBuilder.DropColumn(
                name: "brand",
                table: "products");

            migrationBuilder.DropColumn(
                name: "custom_ID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "product_type",
                table: "products");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "products");

            migrationBuilder.AddColumn<Guid>(
                name: "brandId",
                table: "products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "product_typeId",
                table: "products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_products_brandId",
                table: "products",
                column: "brandId");

            migrationBuilder.CreateIndex(
                name: "IX_products_product_typeId",
                table: "products",
                column: "product_typeId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_brandId",
                table: "products",
                column: "brandId",
                principalTable: "brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_product_types_product_typeId",
                table: "products",
                column: "product_typeId",
                principalTable: "product_types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
