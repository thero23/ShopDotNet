using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addFeedbackTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equals_Products_ProductId",
                table: "Equals");

            migrationBuilder.DropIndex(
                name: "IX_Equals_ProductId",
                table: "Equals");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3aff40a0-df6b-4f20-afdb-0a00d845f904");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8f31c9f5-fffa-451d-b337-410da7aa29f6");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bb38aa0e-5318-4c2c-872f-152a3ac84996",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "315121d5-4600-4da5-ba5d-84402ce527a9");

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "656d0214-1f6d-4746-a967-f9930f0af0b3", "8e8ff46a-d8da-49da-8cde-4837683bed7d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a45eced-fa11-4a0d-ae47-a1f7f96025b9", "bea436e0-fe50-4a8b-a363-e9d72c7c9854", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ProductId",
                table: "Feedbacks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "656d0214-1f6d-4746-a967-f9930f0af0b3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6a45eced-fa11-4a0d-ae47-a1f7f96025b9");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "315121d5-4600-4da5-ba5d-84402ce527a9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bb38aa0e-5318-4c2c-872f-152a3ac84996");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3aff40a0-df6b-4f20-afdb-0a00d845f904", "ec5bd824-c877-4854-be82-e7623031cd44", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f31c9f5-fffa-451d-b337-410da7aa29f6", "94a99dd2-14b5-4405-8de3-a1be25da44e0", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Equals_ProductId",
                table: "Equals",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equals_Products_ProductId",
                table: "Equals",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
