using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_brandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "products",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "brandId",
                table: "products",
                newName: "Brand");

            migrationBuilder.RenameIndex(
                name: "IX_products_categoryId",
                table: "products",
                newName: "IX_products_Category");

            migrationBuilder.RenameIndex(
                name: "IX_products_brandId",
                table: "products",
                newName: "IX_products_Brand");

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_Brand",
                table: "products",
                column: "Brand",
                principalTable: "brands",
                principalColumn: "brandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_Category",
                table: "products",
                column: "Category",
                principalTable: "categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_Brand",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_Category",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "products",
                newName: "categoryId");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "products",
                newName: "brandId");

            migrationBuilder.RenameIndex(
                name: "IX_products_Category",
                table: "products",
                newName: "IX_products_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_Brand",
                table: "products",
                newName: "IX_products_brandId");

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
    }
}
