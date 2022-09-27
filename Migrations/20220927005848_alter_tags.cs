using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myapi.Migrations
{
    /// <inheritdoc />
    public partial class altertags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_products_ProductId",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Tag",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_products_ProductId",
                table: "Tag",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_products_ProductId",
                table: "Tag");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Tag",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_products_ProductId",
                table: "Tag",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id");
        }
    }
}
