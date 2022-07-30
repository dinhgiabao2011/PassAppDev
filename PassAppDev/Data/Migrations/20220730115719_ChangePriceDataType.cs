using Microsoft.EntityFrameworkCore.Migrations;

namespace PassAppDev.Data.Migrations
{
    public partial class ChangePriceDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "OrderedBooks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderedBooks",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

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
        }
    }
}
