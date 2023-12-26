using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Brand_brandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Category_categoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "brands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_brands",
                table: "brands",
                column: "brandId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_brandId",
                table: "products",
                column: "brandId",
                principalTable: "brands",
                principalColumn: "brandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryId",
                table: "products",
                column: "categoryId",
                principalTable: "categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_brands",
                table: "brands");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "brands",
                newName: "Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "brandId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Brand_brandId",
                table: "products",
                column: "brandId",
                principalTable: "Brand",
                principalColumn: "brandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Category_categoryId",
                table: "products",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
