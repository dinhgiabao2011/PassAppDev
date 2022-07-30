using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class UpdateCartBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "CartBooks",
                nullable: false,
                defaultValue: 0f);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "CartBooks");

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
        }
    }
}
