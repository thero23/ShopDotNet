using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddPrimaryKeyToorderProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "39121193-1081-4498-a2b8-48e315500720");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb9abc0d-7ca8-44a5-be96-cbfbf7112fe6");

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
                oldDefaultValue: "0a07c26d-56c6-4d54-9ebd-1f67097823fc");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17d8b4f1-d471-413f-b6cc-5bac92f62da8", "bd1a512b-2a30-4ce9-92e7-201bd396839a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c8eab25-5b7b-451d-9926-d7ea22f18302", "5d7fb66c-72ff-4752-a7ee-20c925b7edc0", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: "0a07c26d-56c6-4d54-9ebd-1f67097823fc",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5bb0c292-bd1c-4036-92ec-e998bea73b21");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39121193-1081-4498-a2b8-48e315500720", "9498cfed-641d-45ab-ab92-237afdbc7a2b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb9abc0d-7ca8-44a5-be96-cbfbf7112fe6", "ecd6a195-7d28-4df8-b5cd-b19105240c83", "User", "USER" });
        }
    }
}
