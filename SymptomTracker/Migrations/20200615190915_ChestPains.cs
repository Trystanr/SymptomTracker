using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class ChestPains : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dfe76-b4eb-4904-8c55-35f9f79ec513");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc8a656d-8c98-40eb-820f-37be5c0d08e7");

            migrationBuilder.AddColumn<bool>(
                name: "ChestPain",
                table: "Symptom",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84407c45-524b-4001-ace1-dfef52870180", "825b95e5-0a25-45a0-a77e-65c63683a4af", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cbb270c-90e0-40df-939b-932bb3230490", "940126cc-90da-416c-9ccf-b6fd00752fd5", "Doctor", "DOCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cbb270c-90e0-40df-939b-932bb3230490");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84407c45-524b-4001-ace1-dfef52870180");

            migrationBuilder.DropColumn(
                name: "ChestPain",
                table: "Symptom");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb3dfe76-b4eb-4904-8c55-35f9f79ec513", "99a8bfe2-d21f-4d0b-938e-4c91cc120c62", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc8a656d-8c98-40eb-820f-37be5c0d08e7", "5cefd400-bd46-4128-a93d-eed3055e2b21", "Doctor", "DOCTOR" });
        }
    }
}
