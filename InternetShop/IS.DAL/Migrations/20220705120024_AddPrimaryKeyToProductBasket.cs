using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddPrimaryKeyToProductBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsBaskets_Baskets_BasketId",
                table: "ProductsBaskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsBaskets",
                table: "ProductsBaskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5cf2a86f-b724-45f4-a67b-b34fed15b5de");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "70805eb9-833d-47be-9017-4e24748f333a");

            migrationBuilder.AlterColumn<string>(
                name: "BasketId",
                table: "ProductsBaskets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductsBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "909f73bc-4700-4496-b303-70be05303363",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsBaskets",
                table: "ProductsBaskets",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1afc25dc-f683-4e0a-8b00-43aed96d443e", "0c2973ac-f506-44da-9fa3-cd35c8b9abbf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69bb37e4-9813-40d5-a9c4-e8fe8f820f17", "66b65458-1288-45b8-929f-3f9711122853", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBaskets_BasketId",
                table: "ProductsBaskets",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsBaskets_Baskets_BasketId",
                table: "ProductsBaskets",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsBaskets_Baskets_BasketId",
                table: "ProductsBaskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsBaskets",
                table: "ProductsBaskets");

            migrationBuilder.DropIndex(
                name: "IX_ProductsBaskets_BasketId",
                table: "ProductsBaskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1afc25dc-f683-4e0a-8b00-43aed96d443e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "69bb37e4-9813-40d5-a9c4-e8fe8f820f17");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductsBaskets");

            migrationBuilder.AlterColumn<string>(
                name: "BasketId",
                table: "ProductsBaskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "909f73bc-4700-4496-b303-70be05303363");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsBaskets",
                table: "ProductsBaskets",
                columns: new[] { "BasketId", "ProductId" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cf2a86f-b724-45f4-a67b-b34fed15b5de", "088c7956-cf61-4d65-a23d-6055f089e430", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70805eb9-833d-47be-9017-4e24748f333a", "4f1e2ff2-734b-4be8-8fda-96e53836ac7a", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsBaskets_Baskets_BasketId",
                table: "ProductsBaskets",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
