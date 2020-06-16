using Microsoft.EntityFrameworkCore.Migrations;

namespace SymptomTracker.Migrations
{
    public partial class RemoveTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Title",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Title",
                table: "Symptom",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84407c45-524b-4001-ace1-dfef52870180", "825b95e5-0a25-45a0-a77e-65c63683a4af", "Patient", "PATIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cbb270c-90e0-40df-939b-932bb3230490", "940126cc-90da-416c-9ccf-b6fd00752fd5", "Doctor", "DOCTOR" });
        }
    }
}
