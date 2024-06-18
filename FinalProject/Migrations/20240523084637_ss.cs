using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ae2a69-647f-4af2-aa65-60efed10d52e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c81b9200-96ac-41aa-8b1c-95c37f64dc98");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3af1f098-d786-495a-8eb7-fcd15b50c0a8", "7facf00b-f8d6-41c8-b378-337d0ef6d52d", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7391e223-514d-48c1-b6a8-2333903de293", "b09c7536-9663-4b75-b6e2-51d3f0d40876", "User", "user" });

            migrationBuilder.CreateIndex(
                name: "IX_orders_CustomerID",
                table: "orders",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_CustomerID",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af1f098-d786-495a-8eb7-fcd15b50c0a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7391e223-514d-48c1-b6a8-2333903de293");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "CustomerID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32ae2a69-647f-4af2-aa65-60efed10d52e", "260ae243-7db2-4e18-a3c9-3b117dc59b58", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c81b9200-96ac-41aa-8b1c-95c37f64dc98", "43e82bc7-5cad-49b6-a841-38cad95aa37a", "User", "user" });
        }
    }
}
