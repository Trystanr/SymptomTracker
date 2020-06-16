using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class SymptomList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e4a8c5b-5707-4b9e-b776-253e98a6634e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4cfe9c9-a52a-44d1-9003-fdef3ee6e48a");

            migrationBuilder.AddColumn<string>(
                name: "SymptomList",
                table: "Symptom",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e2cafb2-1b84-41c7-8b56-fcc999e68f8b", "4f913d65-c81b-4aac-899c-a67ef1e7fefb", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0c2dab3-257c-4611-bee8-106afa5b6e12", "457ca011-c464-4bcc-a2de-af2c829d5da6", "Doctor", "DOCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e2cafb2-1b84-41c7-8b56-fcc999e68f8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0c2dab3-257c-4611-bee8-106afa5b6e12");

            migrationBuilder.DropColumn(
                name: "SymptomList",
                table: "Symptom");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e4a8c5b-5707-4b9e-b776-253e98a6634e", "2409bdba-c2ba-4450-945f-d37ceca523bf", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4cfe9c9-a52a-44d1-9003-fdef3ee6e48a", "0b92c72e-b2bb-42c2-a352-bc4f6901e008", "Doctor", "DOCTOR" });
        }
    }
}
