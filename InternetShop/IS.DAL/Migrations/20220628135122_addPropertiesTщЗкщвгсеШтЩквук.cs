using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addPropertiesTщЗкщвгсеШтЩквук : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "194604eb-d167-4d0b-82e1-16bfe1529072");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bd5e2d96-7431-45ef-a24a-4a828b428890");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "productInOrderEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b0f10b5-0dc7-419e-b217-03209219e372", "0c48788e-fd6d-4d52-97b5-834655b68623", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75bdcde7-6291-42d6-9d43-0fc45f6d12c8", "9124c2f2-d012-4d6e-bcf5-90969a22e67f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3b0f10b5-0dc7-419e-b217-03209219e372");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "75bdcde7-6291-42d6-9d43-0fc45f6d12c8");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "productInOrderEntities");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "194604eb-d167-4d0b-82e1-16bfe1529072", "a1cf3a8f-7e08-4ab2-bd81-e8cb864c7ff9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd5e2d96-7431-45ef-a24a-4a828b428890", "d3c114b0-32c4-4647-8587-38d44565fddd", "User", "USER" });
        }
    }
}
