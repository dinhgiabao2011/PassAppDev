using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddNotificationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    NotifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29deacf2-61bd-4bdc-8f7a-a9d20bf4fb8c", "AQAAAAEAACcQAAAAEDmQ4dIR4HxicL7z6c9wgAd1rpuy8E/+dJzCfFXbtu5h7LDAKJr8RWn0XinmAhzTww==", "f82d59a6-2fd1-4e29-bb8f-9092f7421412" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7175c261-5242-4f48-909b-b7cbf35d9ae0", "AQAAAAEAACcQAAAAEKLOezrJ0fEEjzWCRGY9uvQMz1NbtUgmwQB882Kqth231cOJ9pR4cVRFCn6WvD/uzg==", "d84938e1-141c-4598-8b4d-810958691357" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29edfe9a-b952-42ba-8aa8-a0394c4bb67a", "AQAAAAEAACcQAAAAENL7T0j0mUtrUxcfMWo9voOw4AhrT2CKGi8ResBcQ2ZwGS6FUjP+MR6gMlBHdTmUWg==", "f54dac14-8024-4241-909b-a7ec5807d055" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc468bae-bb0a-40c4-b723-c3c719ab7b10", "AQAAAAEAACcQAAAAEF81spIJV8fD7GJzyPQG6f4Hzyt8hvpzblxkoKmOIencdzqxgDlGz/Zv2SMlopvlvw==", "e8d397b5-36e8-4a08-92bd-d0afa5ae2cfa" });
        }
    }
}
