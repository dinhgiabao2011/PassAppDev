using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddRelationBetweenApplicationUserAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Categories",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ApplicationUserId",
                table: "Categories",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_ApplicationUserId",
                table: "Categories",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "900435fb-cb5f-43b2-a576-6954936f558f", "AQAAAAEAACcQAAAAED3yPugM7WkY1kIxkXj2NAybalM0tAW9LV8KcAXvvozbJIq3+hz/a2wqNes3lp+mhw==", "c9e96454-d9c4-4bb3-8d84-8ed0ef7060ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2faf4e02-cc79-442a-a578-14a3bb32f6fd", "AQAAAAEAACcQAAAAEEKyxghwCBxBVTKxubcL1kV99oaTgco9JpIpIeBxOnzFYNkRhVVQkMLgoo8S5yvdTg==", "accd7d32-b6cc-420e-80a6-e52202d44966" });
        }
    }
}
