using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e644b1a2-248f-4479-a7df-596aaebb9766", "3", "customer", "customer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "766503e1-b8c9-4741-9565-6adca9bcc15b", "AQAAAAEAACcQAAAAEL/jKcxufFfRsQ9fMrzH/FdhKWzJy6sWqnQ1oC6ORwExORoHR2N1ZfKycLtn6p155Q==", "e9d9edcc-41ea-485c-9d76-575ada583132" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e046dc64-3885-4f1b-a62d-8814283ebec9", "AQAAAAEAACcQAAAAEL/5bR5kZ26mZ0qZnRQCr1dpLWGDupCkAGc55dq6gA73RCZjM/djt6/epexo0o46LA==", "70e302c3-9668-4d5a-832e-fe0e9dde6711" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e644b1a2-248f-4479-a7df-596aaebb9766");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f5b40e6-d667-4584-bd33-753916ff2a65", "AQAAAAEAACcQAAAAEDlM0/7u5pO3Zvyh+iJxlPcZTTE3vv+77UiMYmkGOazF9SHA2qcruZ/bN421d0aW8g==", "e53d9747-4a94-41d2-ae4b-f120bdac6719" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "258edc75-f49d-409f-b1a2-4d757d5c442a", "AQAAAAEAACcQAAAAENcdsNV2TA7vMFeURS630wVbeKUYPz7fp/gvpoF33fWcF2TC1+cuZXZTWj3KxSjvMA==", "59b7effa-ed7b-438c-8e77-a28b542cad58" });
        }
    }
}
