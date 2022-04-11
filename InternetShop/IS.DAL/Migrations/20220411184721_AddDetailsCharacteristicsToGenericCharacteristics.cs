using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddDetailsCharacteristicsToGenericCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2342dfe6-e07b-44f5-905b-ca6ed3c582e3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "77215adc-24ef-4bb8-8653-9ae45bf54824");

            migrationBuilder.AddColumn<string>(
                name: "DetailsCharacteristicId",
                table: "GenericCharacteristic",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DetailsCharacteristic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenericCharacteristicId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsCharacteristic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsCharacteristic_GenericCharacteristic_GenericCharacteristicId",
                        column: x => x.GenericCharacteristicId,
                        principalTable: "GenericCharacteristic",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cc93558-d8bf-4fce-9a7a-0bcec809b555", "6fd16840-604c-4a8b-9352-df63ffdb1c1d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b065513-cf2e-4bcf-9167-2cb3678bd4ef", "595b85ab-77a4-4c6c-8976-1393df2b6513", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_DetailsCharacteristic_GenericCharacteristicId",
                table: "DetailsCharacteristic",
                column: "GenericCharacteristicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailsCharacteristic");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1cc93558-d8bf-4fce-9a7a-0bcec809b555");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4b065513-cf2e-4bcf-9167-2cb3678bd4ef");

            migrationBuilder.DropColumn(
                name: "DetailsCharacteristicId",
                table: "GenericCharacteristic");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2342dfe6-e07b-44f5-905b-ca6ed3c582e3", "540b8acb-f898-438c-8a49-105c2b31311b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77215adc-24ef-4bb8-8653-9ae45bf54824", "81edaba6-f771-4795-a50f-88e231d0cd6a", "User", "USER" });
        }
    }
}
