using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class ClassFunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e2cafb2-1b84-41c7-8b56-fcc999e68f8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0c2dab3-257c-4611-bee8-106afa5b6e12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e302f95a-5b6e-4628-a9d6-569f99c7cc0e", "ca436508-c919-4215-b181-f1df6916d8ea", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8fa47651-5a6c-493a-a0ca-3fef11d8479a", "a4a23e77-445e-498f-a771-1a316d34f513", "Doctor", "DOCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa47651-5a6c-493a-a0ca-3fef11d8479a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e302f95a-5b6e-4628-a9d6-569f99c7cc0e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e2cafb2-1b84-41c7-8b56-fcc999e68f8b", "4f913d65-c81b-4aac-899c-a67ef1e7fefb", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0c2dab3-257c-4611-bee8-106afa5b6e12", "457ca011-c464-4bcc-a2de-af2c829d5da6", "Doctor", "DOCTOR" });
        }
    }
}
