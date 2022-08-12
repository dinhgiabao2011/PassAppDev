using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c8119d8-c809-41a3-bd5a-3780e52b66f7", "AQAAAAEAACcQAAAAEJKRFsvqdixPhWhorTc1bTEVYEycAY2cHZLuxJY03yWI5eOTolGRv6E8uSEIlroi2g==", "19207b01-d9d4-40fd-b95c-e91b1072b038" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b00710-b0c7-4693-961d-7af430e0191d", "AQAAAAEAACcQAAAAEJUM9Q6vNKUqH2d9p5MuG6vKDPgD8zo0KbI1HWBpkdDmeh1Qk8FQqbfnmDw3zvodLQ==", "49cce7ec-f2cb-438a-898d-d43d80060c2a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
