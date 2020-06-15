using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class WellBeing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f5e96d-332f-4ba1-9bf5-ff35781bcd4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ec292ab-1bb2-40c3-ace2-f686591a0e42");

            migrationBuilder.AddColumn<int>(
                name: "WellBeing",
                table: "Symptom",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb3dfe76-b4eb-4904-8c55-35f9f79ec513", "99a8bfe2-d21f-4d0b-938e-4c91cc120c62", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc8a656d-8c98-40eb-820f-37be5c0d08e7", "5cefd400-bd46-4128-a93d-eed3055e2b21", "Doctor", "DOCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dfe76-b4eb-4904-8c55-35f9f79ec513");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc8a656d-8c98-40eb-820f-37be5c0d08e7");

            migrationBuilder.DropColumn(
                name: "WellBeing",
                table: "Symptom");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49f5e96d-332f-4ba1-9bf5-ff35781bcd4a", "fa06f1d3-d183-4030-b711-8f1b856887ce", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ec292ab-1bb2-40c3-ace2-f686591a0e42", "b4116b34-75d5-419c-bdd7-01ae82c09365", "Doctor", "DOCTOR" });
        }
    }
}
