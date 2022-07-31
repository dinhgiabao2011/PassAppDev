using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class UpdateNotificationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Notifications");

            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "Notifications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Decision",
                table: "Notifications",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "614f1da0-b81b-4415-a726-c0782e45533e", "AQAAAAEAACcQAAAAEG0mEdYWUBHwLq0ro7d/LfXRc3kzIhznaGkSH2qLLa8eNw/eoN56KPQTIrolz1a+UA==", "6ce9f75c-65ed-402a-a888-fb9c2d442a92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fc205ce-af14-484d-a30b-7e0a68933538", "AQAAAAEAACcQAAAAEKhKVI/vOCAsUTWCQOdjPFNeAofu2PqWiN0qi/FS6uGjH3rnev9pu6K1mIjSdjfopg==", "23225c9a-234c-4aa9-9e8d-076a369e9a8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "Decision",
                table: "Notifications");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
