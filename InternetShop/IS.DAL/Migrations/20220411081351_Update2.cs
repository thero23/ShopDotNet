using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6390ea22-cc5e-4894-b5d8-dab3bc1482b7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d9ad2745-01df-41e3-9951-27f7f09bc150");

            migrationBuilder.CreateTable(
                name: "GenericCharacteristic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericCharacteristic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGenericCharacteristic",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    GenericCharacteristicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGenericCharacteristic", x => new { x.ProductId, x.GenericCharacteristicId });
                    table.ForeignKey(
                        name: "FK_ProductGenericCharacteristic_GenericCharacteristic_GenericCharacteristicId",
                        column: x => x.GenericCharacteristicId,
                        principalTable: "GenericCharacteristic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductGenericCharacteristic_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2342dfe6-e07b-44f5-905b-ca6ed3c582e3", "540b8acb-f898-438c-8a49-105c2b31311b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77215adc-24ef-4bb8-8653-9ae45bf54824", "81edaba6-f771-4795-a50f-88e231d0cd6a", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductGenericCharacteristic_GenericCharacteristicId",
                table: "ProductGenericCharacteristic",
                column: "GenericCharacteristicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductGenericCharacteristic");

            migrationBuilder.DropTable(
                name: "GenericCharacteristic");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2342dfe6-e07b-44f5-905b-ca6ed3c582e3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "77215adc-24ef-4bb8-8653-9ae45bf54824");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6390ea22-cc5e-4894-b5d8-dab3bc1482b7", "a51a5968-3970-4ddf-8f97-75a5bc941f1f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9ad2745-01df-41e3-9951-27f7f09bc150", "33144623-4fed-4f32-99e7-25cbec62ea16", "User", "USER" });
        }
    }
}
