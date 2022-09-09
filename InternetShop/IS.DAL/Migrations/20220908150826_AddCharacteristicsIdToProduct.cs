using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddCharacteristicsIdToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7a56262c-b7d2-4625-9ceb-e9b6461de7d1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d280d678-e47e-4864-993f-492b9c06d3f5");

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5f2d2272-b784-4402-be64-0b5e36dd84c4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5afa1623-db2d-44b7-848d-13aa8f156539");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76c29573-63e2-46ca-a671-b64ff60dcfbd", "08f025be-52c0-4dec-9ea4-4312d6434483", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9fa7b352-372b-4737-bbe0-9bf568190dea", "17b3c59d-a86f-4166-b361-c0af69eca7d4", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "76c29573-63e2-46ca-a671-b64ff60dcfbd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9fa7b352-372b-4737-bbe0-9bf568190dea");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5afa1623-db2d-44b7-848d-13aa8f156539",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5f2d2272-b784-4402-be64-0b5e36dd84c4");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a56262c-b7d2-4625-9ceb-e9b6461de7d1", "b456d98e-d286-405d-b5d5-0b541deb8f52", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d280d678-e47e-4864-993f-492b9c06d3f5", "0355a44b-6eb9-406f-bd86-2377da21eaf5", "User", "USER" });
        }
    }
}
