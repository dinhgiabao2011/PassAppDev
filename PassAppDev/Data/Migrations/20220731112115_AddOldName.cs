using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddOldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewName",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "OldName",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d718400-6fbd-4fcf-80ef-c7f098c9f9ad", "AQAAAAEAACcQAAAAEKMFmoSUiMNMa0FqntZm9Rr81nFNiWZxX8K4qgVtG80I5ka9khu5KYcGeGK7xeTfnA==", "80574775-9be8-46dc-b535-aea2803e7665" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8401c0c-a4e6-49e9-b17a-4399976ace31", "AQAAAAEAACcQAAAAEIIpD5aPcW2Ut2k3GK3d3JbqFeQodMa0H0uxJrNIGStWSxAtTKEfqWE1wXoLJf8a6Q==", "8968a6d1-08ac-410d-8240-e37695227f7d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldName",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "NewName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6359f4e-6103-47e8-ab3f-e6b51902b115", "AQAAAAEAACcQAAAAEHxMuk/ucOE+tO8CT3N21VGYPtaTqXOCKpdZsSP9MHo+5Czi3wwJjMCKuz7rgSC+qg==", "e9be68ec-4133-4ad8-aaba-b83f4b8070d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b82bad93-834c-4e4b-a98f-4c6a48655c94", "AQAAAAEAACcQAAAAELvrIAXIbBg7ytuYapTe+b70jbt2xKP5slMrFAgdrj1wO2YXqAoJoAAplrpqGi2YGQ==", "4f7c2c48-29c1-4e45-98cc-818867ad2998" });
        }
    }
}
