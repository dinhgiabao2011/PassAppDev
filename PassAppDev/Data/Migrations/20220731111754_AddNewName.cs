using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddNewName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewName",
                table: "Categories",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewName",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9c70ae2-06dc-49dc-8667-91f0cf30bc28", "AQAAAAEAACcQAAAAEBjOkvd5N5Y+mCSI4pmp/sJjk5IX7NkD80tsrkeSGjIOKhO0zLt22aGb30vBqahQUw==", "6c7f03be-ce49-4db0-8c14-df8532dfd2e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9360b34c-4d63-4159-83ef-c3572b3f6812", "AQAAAAEAACcQAAAAEDpI0LEqeUNq3YORXwakbyiJrByJsZSPWPM8cKAw8MkTzC0W0MPYX28scPAMgXbeEg==", "a5640d22-36b1-4047-87d7-58e3f3edb0c5" });
        }
    }
}
