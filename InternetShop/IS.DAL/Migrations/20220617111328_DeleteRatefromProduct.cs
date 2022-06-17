using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteRatefromProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "43432be8-ce57-4348-a4e6-d40b613c0cf2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a4bf3b62-d822-4010-9dd9-94c69cffa8e6");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40c49742-232b-4d53-842a-4ef0bd480ab0", "5a9c9775-7955-460d-ba0f-5f3836b2f799", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44460941-87da-491c-aec0-8c393849292f", "94fad24f-6697-4914-aa8e-5b6e7a204699", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "40c49742-232b-4d53-842a-4ef0bd480ab0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "44460941-87da-491c-aec0-8c393849292f");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43432be8-ce57-4348-a4e6-d40b613c0cf2", "f6639948-74a9-4c8d-bc81-29dc068b2713", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4bf3b62-d822-4010-9dd9-94c69cffa8e6", "edca1490-06c6-4f25-bb0f-8fd09b997494", "User", "USER" });
        }
    }
}
