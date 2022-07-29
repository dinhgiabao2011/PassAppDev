using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddAdminAccountAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c090913-d178-47d5-89f7-dc2e4c0a08be", "AQAAAAEAACcQAAAAEGVJ1Xq8yyHEJIR+4yfRel2fR5/ZeVW0QojtwcCExa5T7Bz0ceLaimNqia6CwVGGdw==", "ec25f12b-4764-4c7e-b851-de039ac79e52" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40dc7ce6-069e-4829-af35-c86f7da3a14f", null, "846a0a78-d8d5-495a-a4cc-2b130f013022" });
        }
    }
}
