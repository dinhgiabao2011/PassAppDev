using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddCartBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartBooks",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Quatity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartBooks", x => new { x.ApplicationUserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_CartBooks_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae78ad1e-3e82-4441-9f70-a8c0eb74946f", "AQAAAAEAACcQAAAAEMa8KQZY+pIiL10PhQBPXda62WxvGQ9KCIMKSNnMwnWh+9D694y+QlJ5j4LadPJRwg==", "5fe038ab-7fd5-49a9-9213-52dc517a6fd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64880a11-94a2-4b07-9f4d-28daefa6669c", "AQAAAAEAACcQAAAAEBFJZDyAP74nqFoy56tUXtatFTUaLsLgzbWIv147Yz/4/EPPrJNovVbyYMGwUQ4KOw==", "5fae5628-bc49-4ae5-a91f-5fc0de7d712d" });

            migrationBuilder.CreateIndex(
                name: "IX_CartBooks_BookId",
                table: "CartBooks",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartBooks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "888ae6b2-4293-44ff-ae29-2297cfb23eb1", "AQAAAAEAACcQAAAAEAGVz0lqY0it6KISGz2FTOi+rqWLLKcAZPyQHEtqIZ44ohd8yQZZN2WGU6zEbxMwRA==", "9ef00652-f2db-4888-bdbe-6d7350e5336b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61dd8524-66a9-40a6-a5fe-0c2e14b6c329", "AQAAAAEAACcQAAAAEPvMOGudXaZFKfII29BxVTm1lSuxtAR81CZywusSqXPI/W1gX8rthRhsWzi9EsL1qw==", "9a813185-365c-47c4-ab57-4ba4f3d5cd93" });
        }
    }
}
