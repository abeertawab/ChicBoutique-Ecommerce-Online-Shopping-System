using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class est : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_Customers_customerid",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Customers_Customerid",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_Productid",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38862026-d02e-4d65-964a-f23d059b347e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6ac3345-352d-4292-9642-548f6589785f");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "orders",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "Customerid",
                table: "orders",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_orders_Productid",
                table: "orders",
                newName: "IX_orders_ProductID");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "cartItems",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "CartItemId",
                table: "cartItems",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "customerid",
                table: "cart",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_cart_customerid",
                table: "cart",
                newName: "IX_cart_CustomerID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b56529a3-631c-4257-a717-901887806cd1", "c2b00700-a0cf-4ae6-9a09-2b9baa8b3117", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d836e03a-61f0-4abd-9100-745f30d04ed5", "6adeaa1c-8998-4643-9b51-f4be442533a5", "Admin", "admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_cart_Customers_CustomerID",
                table: "cart",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Customers_CustomerID",
                table: "orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_ProductID",
                table: "orders",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_Customers_CustomerID",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Customers_CustomerID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_ProductID",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b56529a3-631c-4257-a717-901887806cd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d836e03a-61f0-4abd-9100-745f30d04ed5");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "orders",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "orders",
                newName: "Customerid");

            migrationBuilder.RenameIndex(
                name: "IX_orders_ProductID",
                table: "orders",
                newName: "IX_orders_Productid");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "cartItems",
                newName: "productid");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "cartItems",
                newName: "CartItemId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "cart",
                newName: "customerid");

            migrationBuilder.RenameIndex(
                name: "IX_cart_CustomerID",
                table: "cart",
                newName: "IX_cart_customerid");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38862026-d02e-4d65-964a-f23d059b347e", "03d66e96-bc6f-4f6b-9f00-d3a59f3f501d", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6ac3345-352d-4292-9642-548f6589785f", "5ef8f02a-014f-41e8-aa7c-9339c4c76ac9", "User", "user" });

            migrationBuilder.AddForeignKey(
                name: "FK_cart_Customers_customerid",
                table: "cart",
                column: "customerid",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Customers_Customerid",
                table: "orders",
                column: "Customerid",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_Productid",
                table: "orders",
                column: "Productid",
                principalTable: "products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
