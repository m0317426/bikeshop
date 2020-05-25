using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class update1901201410 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShoppingItems",
                newName: "ShoppingItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShoppingBags",
                newName: "ShoppingBagId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ShoppingItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingBagId",
                table: "ShoppingItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ShoppingBags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingItemId",
                table: "ShoppingBags",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItems_ProductId",
                table: "ShoppingItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItems_ShoppingBagId",
                table: "ShoppingItems",
                column: "ShoppingBagId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBags_CustomerId",
                table: "ShoppingBags",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_Customers_CustomerId",
                table: "ShoppingBags",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingItems_ShoppingBags_ShoppingBagId",
                table: "ShoppingItems",
                column: "ShoppingBagId",
                principalTable: "ShoppingBags",
                principalColumn: "ShoppingBagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_Customers_CustomerId",
                table: "ShoppingBags");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_Products_ProductId",
                table: "ShoppingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingItems_ShoppingBags_ShoppingBagId",
                table: "ShoppingItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingItems_ProductId",
                table: "ShoppingItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingItems_ShoppingBagId",
                table: "ShoppingItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingBags_CustomerId",
                table: "ShoppingBags");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ShoppingItems");

            migrationBuilder.DropColumn(
                name: "ShoppingBagId",
                table: "ShoppingItems");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ShoppingBags");

            migrationBuilder.DropColumn(
                name: "ShoppingItemId",
                table: "ShoppingBags");

            migrationBuilder.RenameColumn(
                name: "ShoppingItemId",
                table: "ShoppingItems",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ShoppingBagId",
                table: "ShoppingBags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
