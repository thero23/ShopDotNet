using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class renameFieldToProductsCharacteristic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "41bf922a-f867-4cb3-90f3-a39d444b59ad");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9ed1b132-6c0e-491e-a2bd-e85d9ee810f0");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "ProductsCharacteristic");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2ed05ffb-4373-4183-9f98-d39e4e314fb6",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "cc799e08-749b-41c6-9e2d-80b26c090513");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "120eb1a3-0e2e-4321-b79a-17331461bd31", "4ae4e11a-85b2-4436-928c-11dd545095e7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54b2cd3d-34c1-494e-8fa0-68b26259a021", "db0ca672-1c46-40b0-b719-acd5b659e669", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "120eb1a3-0e2e-4321-b79a-17331461bd31");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "54b2cd3d-34c1-494e-8fa0-68b26259a021");

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "ProductsCharacteristic",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "cc799e08-749b-41c6-9e2d-80b26c090513",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2ed05ffb-4373-4183-9f98-d39e4e314fb6");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41bf922a-f867-4cb3-90f3-a39d444b59ad", "be474bfe-bed2-4bec-8c97-9ab9980bd675", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ed1b132-6c0e-491e-a2bd-e85d9ee810f0", "64aa506f-90e4-4ebe-8363-6bdf08ccd6b4", "User", "USER" });
        }
    }
}
