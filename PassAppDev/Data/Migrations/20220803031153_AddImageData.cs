using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddImageData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f80483e-da73-4590-b7de-196ced181f19", "AQAAAAEAACcQAAAAEMdft/ijhi/KMX2Ov3z5eBqjX9tuGAWiwDIT0tlfYAQhy//8TFczU/Nxr1j+VfYhUw==", "87e84f04-eb94-4bb5-b87f-9c7f4c9f530d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c3a7201-20d2-4057-9a01-c045f977c33e", "AQAAAAEAACcQAAAAEJCQbgnoKjgKJJVP1cyP5MBRYo1SExminOZLCycGr8Y6hSDmUz5RMb6qoSwZs6lmrw==", "38a84572-d799-4a36-a510-c28b437f98a1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Books");

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
    }
}
