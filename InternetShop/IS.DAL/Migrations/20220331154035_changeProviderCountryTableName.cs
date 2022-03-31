using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class changeProviderCountryTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProducerCountries_ProviderCountryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProducerCountries",
                table: "ProducerCountries");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "18089121-01d7-4015-b167-10c7c9091100");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e1248e9a-6975-4052-8a15-8f275b803d25");

            migrationBuilder.RenameTable(
                name: "ProducerCountries",
                newName: "ProviderCountries");

            migrationBuilder.RenameColumn(
                name: "FinalPrice",
                table: "Orders",
                newName: "TotalPrice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProviderCountries",
                table: "ProviderCountries",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28f7b8e8-c2b4-4fea-8ccd-7657cfe01568", "566875f0-bbe3-4fc6-8465-6015362a118d", "User", "USER" });


            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProviderCountries_ProviderCountryId",
                table: "Products",
                column: "ProviderCountryId",
                principalTable: "ProviderCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProviderCountries_ProviderCountryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProviderCountries",
                table: "ProviderCountries");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "28f7b8e8-c2b4-4fea-8ccd-7657cfe01568");

            migrationBuilder.RenameTable(
                name: "ProviderCountries",
                newName: "ProducerCountries");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Orders",
                newName: "FinalPrice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProducerCountries",
                table: "ProducerCountries",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18089121-01d7-4015-b167-10c7c9091100", "0e1856e2-f163-4340-acc4-419b1e1d05e7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1248e9a-6975-4052-8a15-8f275b803d25", "47b49ffd-cb5d-4542-9c4b-9f78788d5472", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProducerCountries_ProviderCountryId",
                table: "Products",
                column: "ProviderCountryId",
                principalTable: "ProducerCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
