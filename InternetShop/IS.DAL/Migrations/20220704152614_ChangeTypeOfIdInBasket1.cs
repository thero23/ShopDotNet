using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ChangeTypeOfIdInBasket1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cf194247-95a2-4d2b-baca-fb024ef51841");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d13a16fc-891e-4660-a17b-4e9ed13b657e");

            migrationBuilder.AlterColumn<string>(
                name: "BasketId",
                table: "ProductsBaskets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19f0752c-39e6-4e6c-be75-150a33ac032e", "b63ee38a-0ac9-4847-bb50-f626b977d564", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ef6be7b-d942-444f-af19-072b9859a150", "606bbe45-af48-4dcb-b388-224b8b5f592f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "19f0752c-39e6-4e6c-be75-150a33ac032e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4ef6be7b-d942-444f-af19-072b9859a150");

            migrationBuilder.AlterColumn<int>(
                name: "BasketId",
                table: "ProductsBaskets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Baskets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf194247-95a2-4d2b-baca-fb024ef51841", "cbb7337c-ae13-4bf5-8ee3-d3e48711d13b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d13a16fc-891e-4660-a17b-4e9ed13b657e", "99e9b6dd-4d5c-44e7-a0a0-42b9fe1a4685", "User", "USER" });
        }
    }
}
