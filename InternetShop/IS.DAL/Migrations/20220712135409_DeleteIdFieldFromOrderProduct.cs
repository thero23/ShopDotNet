using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteIdFieldFromOrderProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17d8b4f1-d471-413f-b6cc-5bac92f62da8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9c8eab25-5b7b-451d-9926-d7ea22f18302");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrdersProducts");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "681da06d-a6c2-4ea5-bfe9-a1546d9b8cb2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5bb0c292-bd1c-4036-92ec-e998bea73b21");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e38f39da-6cb4-45af-b56c-211f0fc56e20", "c9175ba7-5e74-4665-9636-0cd97f6742b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e866c8da-3972-4fed-99ff-32e393ddfa7e", "ad3c4c73-df80-4e9f-9f4d-10b41a9a83fe", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e38f39da-6cb4-45af-b56c-211f0fc56e20");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e866c8da-3972-4fed-99ff-32e393ddfa7e");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrdersProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5bb0c292-bd1c-4036-92ec-e998bea73b21",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "681da06d-a6c2-4ea5-bfe9-a1546d9b8cb2");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17d8b4f1-d471-413f-b6cc-5bac92f62da8", "bd1a512b-2a30-4ce9-92e7-201bd396839a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c8eab25-5b7b-451d-9926-d7ea22f18302", "5d7fb66c-72ff-4752-a7ee-20c925b7edc0", "User", "USER" });
        }
    }
}
