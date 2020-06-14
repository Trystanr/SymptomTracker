using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class DobClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97fb3554-f7b3-4511-85b9-768dfce383fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb0c0cac-8bef-44b2-94e9-e78b91d55239");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "745cca22-1d6b-4a84-8b06-5ea119240fdc", "28a07baa-aa60-4e11-b881-751f7dd38a0d", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d561afe-d2e9-490f-9e54-3b3681e4064e", "0e758ad5-87b0-40b0-83e1-a6d14f0b24dc", "Doctor", "DOCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d561afe-d2e9-490f-9e54-3b3681e4064e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "745cca22-1d6b-4a84-8b06-5ea119240fdc");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb0c0cac-8bef-44b2-94e9-e78b91d55239", "08501471-e69d-4036-a8fa-7f010e493f5d", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97fb3554-f7b3-4511-85b9-768dfce383fe", "4b4417a9-f2cd-4ded-b0cc-d398edbee958", "Doctor", "DOCTOR" });
        }
    }
}
