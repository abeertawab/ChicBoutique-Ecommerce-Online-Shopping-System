using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b56529a3-631c-4257-a717-901887806cd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d836e03a-61f0-4abd-9100-745f30d04ed5");

            migrationBuilder.AddColumn<int>(
                name: "producprice",
                table: "cartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quintity",
                table: "cartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32ae2a69-647f-4af2-aa65-60efed10d52e", "260ae243-7db2-4e18-a3c9-3b117dc59b58", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c81b9200-96ac-41aa-8b1c-95c37f64dc98", "43e82bc7-5cad-49b6-a841-38cad95aa37a", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ae2a69-647f-4af2-aa65-60efed10d52e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c81b9200-96ac-41aa-8b1c-95c37f64dc98");

            migrationBuilder.DropColumn(
                name: "producprice",
                table: "cartItems");

            migrationBuilder.DropColumn(
                name: "quintity",
                table: "cartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b56529a3-631c-4257-a717-901887806cd1", "c2b00700-a0cf-4ae6-9a09-2b9baa8b3117", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d836e03a-61f0-4abd-9100-745f30d04ed5", "6adeaa1c-8998-4643-9b51-f4be442533a5", "Admin", "admin" });
        }
    }
}
