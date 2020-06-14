using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class RelatingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d561afe-d2e9-490f-9e54-3b3681e4064e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "745cca22-1d6b-4a84-8b06-5ea119240fdc");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Symptom",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49f5e96d-332f-4ba1-9bf5-ff35781bcd4a", "fa06f1d3-d183-4030-b711-8f1b856887ce", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ec292ab-1bb2-40c3-ace2-f686591a0e42", "b4116b34-75d5-419c-bdd7-01ae82c09365", "Doctor", "DOCTOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Symptom_OwnerId",
                table: "Symptom",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Symptom_AspNetUsers_OwnerId",
                table: "Symptom",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Symptom_AspNetUsers_OwnerId",
                table: "Symptom");

            migrationBuilder.DropIndex(
                name: "IX_Symptom_OwnerId",
                table: "Symptom");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f5e96d-332f-4ba1-9bf5-ff35781bcd4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ec292ab-1bb2-40c3-ace2-f686591a0e42");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Symptom");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "745cca22-1d6b-4a84-8b06-5ea119240fdc", "28a07baa-aa60-4e11-b881-751f7dd38a0d", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d561afe-d2e9-490f-9e54-3b3681e4064e", "0e758ad5-87b0-40b0-83e1-a6d14f0b24dc", "Doctor", "DOCTOR" });
        }
    }
}
