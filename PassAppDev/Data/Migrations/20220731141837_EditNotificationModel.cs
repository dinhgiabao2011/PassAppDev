using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class EditNotificationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Notifications",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc3a32ca-6859-4914-a575-c1d1754f50ff", "AQAAAAEAACcQAAAAEEwR+EE4msog/kWVJ6wu61VXPkKUk18uGZKOMKulZp6t7oZAJkXHwe5gnzyb+fAfkg==", "c37c4209-1220-464a-ac0c-5e8981097d04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bccceaca-c3e4-4b71-b449-a97f4c6f9176", "AQAAAAEAACcQAAAAEKSnqH8a0mMz+OBU+MV4+cn+bjpMkUolAjFuTUHC7CWDVaUcHdVVaL2OGgm4PrDQzA==", "8a7b0ef4-6782-403c-89ea-65029565c605" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "Notifications",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
