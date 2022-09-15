using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class deleteProductsCharacteristicsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "15840fd6-a405-4400-85a3-24404a33d5e0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fd765c1d-85b7-4618-9bb1-0fb2540851bf");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "895df220-9c71-48f7-8b3f-c2ec9b14ed7f",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d99e3edf-f105-444b-827b-02284e7bfee0");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30175e81-c1aa-42e9-847e-6acc9bb867ab", "6154bc7d-f0eb-4279-9511-a65897bd765b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "789767a7-b9eb-417e-ae61-4fdbe75a04a8", "de57bc88-06ac-4bdb-90c4-b06bb9b9b19e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "30175e81-c1aa-42e9-847e-6acc9bb867ab");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "789767a7-b9eb-417e-ae61-4fdbe75a04a8");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d99e3edf-f105-444b-827b-02284e7bfee0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "895df220-9c71-48f7-8b3f-c2ec9b14ed7f");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15840fd6-a405-4400-85a3-24404a33d5e0", "df0109b0-8c7c-43b7-b050-a5f0e3266d27", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd765c1d-85b7-4618-9bb1-0fb2540851bf", "684dbaf3-7a10-4240-a5b8-781761d94e67", "User", "USER" });
        }
    }
}
