using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddStoreAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "258edc75-f49d-409f-b1a2-4d757d5c442a", "AQAAAAEAACcQAAAAENcdsNV2TA7vMFeURS630wVbeKUYPz7fp/gvpoF33fWcF2TC1+cuZXZTWj3KxSjvMA==", "59b7effa-ed7b-438c-8e77-a28b542cad58" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a0554bfd-1d4d-4a61-97d4-d827530e6883", 0, null, "6f5b40e6-d667-4584-bd33-753916ff2a65", "store@gmail.com", false, null, false, null, null, null, "AQAAAAEAACcQAAAAEDlM0/7u5pO3Zvyh+iJxlPcZTTE3vv+77UiMYmkGOazF9SHA2qcruZ/bN421d0aW8g==", "1234567890", false, "e53d9747-4a94-41d2-ae4b-f120bdac6719", false, "store@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a0554bfd-1d4d-4a61-97d4-d827530e6883", "c7b013f0-5201-4317-abd8-c211f91b7330" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a0554bfd-1d4d-4a61-97d4-d827530e6883", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c090913-d178-47d5-89f7-dc2e4c0a08be", "AQAAAAEAACcQAAAAEGVJ1Xq8yyHEJIR+4yfRel2fR5/ZeVW0QojtwcCExa5T7Bz0ceLaimNqia6CwVGGdw==", "ec25f12b-4764-4c7e-b851-de039ac79e52" });
        }
    }
}
