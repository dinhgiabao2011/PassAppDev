using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddIdInCartBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartBooks_AspNetUsers_ApplicationUserId",
                table: "CartBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "CartBooks",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CartBooks",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd772204-c9bd-45cb-b4a5-8399bdec80fa", "AQAAAAEAACcQAAAAEB9ejudG2TFJO7wPOsioOa1rkag53j9jTr+M3OIeUlZQhklNCogp9yInB7PpLbjUIQ==", "c0bc7c57-6681-4285-89da-cc80479b68b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce37f2dd-7048-415d-952d-660aeb4dcb91", "AQAAAAEAACcQAAAAEAtfMD6tv2khJKD/Qj8N9fQSUdKYk8pG7oLNa9GlfBd5+oGbFwcjil/jTesWAvqh9w==", "bc18136b-3503-4479-a144-2cb15b7d4c6f" });

            migrationBuilder.CreateIndex(
                name: "IX_CartBooks_ApplicationUserId",
                table: "CartBooks",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartBooks_AspNetUsers_ApplicationUserId",
                table: "CartBooks",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartBooks_AspNetUsers_ApplicationUserId",
                table: "CartBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks");

            migrationBuilder.DropIndex(
                name: "IX_CartBooks_ApplicationUserId",
                table: "CartBooks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CartBooks");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "CartBooks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartBooks",
                table: "CartBooks",
                columns: new[] { "ApplicationUserId", "BookId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97da8787-e244-4a2e-a3a4-3c403f86ee34", "AQAAAAEAACcQAAAAEK4pBXjcs6gVW2W3OqqlER/gHRvEY7uLc617LNuq0AiXk6IyZRvupmT7YpUPzIEsLQ==", "f21443f3-8106-4b10-b40c-42513880896e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0aca0af-8a10-4171-b2d2-8fe9818b4dbd", "AQAAAAEAACcQAAAAEImfrSXULFqXRIM6RWsVDugGG8oZWryiX5iebrNQW/TqsKgjnvyyNETFfxxX9GXrtA==", "8d578a64-71c9-40f6-8385-0782fd27a6d7" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartBooks_AspNetUsers_ApplicationUserId",
                table: "CartBooks",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
