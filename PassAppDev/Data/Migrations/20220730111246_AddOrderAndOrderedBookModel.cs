using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class AddOrderAndOrderedBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    OrderedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderedBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderedBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderedBooks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0554bfd-1d4d-4a61-97d4-d827530e6883",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36ad1683-c48c-465b-9e1e-90b44b77f405", "AQAAAAEAACcQAAAAELXRh1j/dHD+msS2UGjkXZAxbI1dPP0zbOjAdAxg3+IgzeVQzpIZWIaGa2Gj44c07Q==", "9e6f6eb5-79f6-4018-9780-8065292ff8fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "557be0c1-e299-4c9f-85de-0671c05ec0be", "AQAAAAEAACcQAAAAEBsYp4L9cOp99TM6slqPGHag7ndmRZ3lcn+0E7fVNWPlUs9qyhO3nthMw4Mmmz8v0w==", "f74cb977-3c81-4db0-9e0b-154e8ff06ba6" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedBooks_BookId",
                table: "OrderedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedBooks_OrderId",
                table: "OrderedBooks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderedBooks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
