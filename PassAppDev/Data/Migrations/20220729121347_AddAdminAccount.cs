using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, null, "40dc7ce6-069e-4829-af35-c86f7da3a14f", "admin@gmail.com", false, null, false, null, null, null, null, "1234567890", false, "846a0a78-d8d5-495a-a4cc-2b130f013022", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", "fab4fac1-c546-41de-aebc-a14da6895711" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");
        }
    }
}
