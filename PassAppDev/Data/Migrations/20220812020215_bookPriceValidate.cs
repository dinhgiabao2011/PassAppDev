using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class bookPriceValidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbf0de2f-9f0d-4222-a4ff-7b59ade52f1d", "AQAAAAEAACcQAAAAEGk1ctY8ZVL/IWUx4YiZ96MxNXwa9KfN7Ytwush7RplJjmcR5yUPC9L9mFApHSg1Pw==", "3080d339-ca22-4664-8972-a511ef0d0df1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "356bb56f-b8df-4273-839e-d676d736bb72", "AQAAAAEAACcQAAAAELPlzKEdehItApQLFAK3iBQ24UMkWHZD9C+UmyvEEEkMstcku+479JY1ienNO3ei7A==", "1b08500a-13ed-47ab-85dc-6d928fe5bba8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
