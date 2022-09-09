using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addCharacteristicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "190286c1-20ab-4b7f-9506-2afbceb01c4f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d570cf4f-3b98-4e88-8054-b3c295e70ef1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e4bcba7e-5c72-47d6-a366-d5114b534676",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "964ce87d-e69b-4a7a-ada5-27f2005f42e4");

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalCharacteristicsEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CharacteristicsEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCharacteristicsEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCharacteristicsEntity_Characteristics_CharacteristicsEntityId",
                        column: x => x.CharacteristicsEntityId,
                        principalTable: "Characteristics",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a242910-5ac1-4339-8c59-19e177fc631d", "1b048206-2789-4c73-b668-df50766d59ae", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9d136b9-6717-4c96-a373-62db2c8d4079", "692b1f26-6f63-440b-979e-e267512ee986", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCharacteristicsEntity_CharacteristicsEntityId",
                table: "AdditionalCharacteristicsEntity",
                column: "CharacteristicsEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalCharacteristicsEntity");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3a242910-5ac1-4339-8c59-19e177fc631d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9d136b9-6717-4c96-a373-62db2c8d4079");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "964ce87d-e69b-4a7a-ada5-27f2005f42e4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e4bcba7e-5c72-47d6-a366-d5114b534676");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "190286c1-20ab-4b7f-9506-2afbceb01c4f", "e5f81699-0373-45b5-885a-92642f73cb83", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d570cf4f-3b98-4e88-8054-b3c295e70ef1", "409d2e11-4a07-4c7e-aec0-83d1214983c9", "User", "USER" });
        }
    }
}
