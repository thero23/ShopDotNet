using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddAdditionalCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalCharacteristicsEntity_Characteristics_CharacteristicsEntityId",
                table: "AdditionalCharacteristicsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalCharacteristicsEntity",
                table: "AdditionalCharacteristicsEntity");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3a242910-5ac1-4339-8c59-19e177fc631d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9d136b9-6717-4c96-a373-62db2c8d4079");

            migrationBuilder.RenameTable(
                name: "AdditionalCharacteristicsEntity",
                newName: "AdditionalCharacteristics");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalCharacteristicsEntity_CharacteristicsEntityId",
                table: "AdditionalCharacteristics",
                newName: "IX_AdditionalCharacteristics_CharacteristicsEntityId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "8c1f1915-81cd-44e5-8cd5-8d5223d1cff5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e4bcba7e-5c72-47d6-a366-d5114b534676");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalCharacteristics",
                table: "AdditionalCharacteristics",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b005d59c-b3b1-47ee-a664-5db02a701b29", "1c8d0eac-6ded-4e3a-8869-1ae9c8bcb2fe", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8e3ff04-f937-4a85-b40d-6a1d39e7164e", "f92f21de-ad62-4446-9a1e-cf5223380113", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalCharacteristics_Characteristics_CharacteristicsEntityId",
                table: "AdditionalCharacteristics",
                column: "CharacteristicsEntityId",
                principalTable: "Characteristics",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalCharacteristics_Characteristics_CharacteristicsEntityId",
                table: "AdditionalCharacteristics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalCharacteristics",
                table: "AdditionalCharacteristics");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b005d59c-b3b1-47ee-a664-5db02a701b29");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d8e3ff04-f937-4a85-b40d-6a1d39e7164e");

            migrationBuilder.RenameTable(
                name: "AdditionalCharacteristics",
                newName: "AdditionalCharacteristicsEntity");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalCharacteristics_CharacteristicsEntityId",
                table: "AdditionalCharacteristicsEntity",
                newName: "IX_AdditionalCharacteristicsEntity_CharacteristicsEntityId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e4bcba7e-5c72-47d6-a366-d5114b534676",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "8c1f1915-81cd-44e5-8cd5-8d5223d1cff5");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalCharacteristicsEntity",
                table: "AdditionalCharacteristicsEntity",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a242910-5ac1-4339-8c59-19e177fc631d", "1b048206-2789-4c73-b668-df50766d59ae", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9d136b9-6717-4c96-a373-62db2c8d4079", "692b1f26-6f63-440b-979e-e267512ee986", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalCharacteristicsEntity_Characteristics_CharacteristicsEntityId",
                table: "AdditionalCharacteristicsEntity",
                column: "CharacteristicsEntityId",
                principalTable: "Characteristics",
                principalColumn: "Id");
        }
    }
}
