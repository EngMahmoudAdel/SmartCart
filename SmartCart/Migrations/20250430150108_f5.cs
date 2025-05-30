using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class f5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76223d5e-02f4-413b-8f1c-1b43cc1ff49e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a633ea7-7db6-453b-b488-a823799cabf0");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cba521d2-af43-483a-91e1-f1fadbc62c75", "e6541ef1-b601-4c65-bfdd-18b785fbbf90", "Admin", "admin" },
                    { "de233b96-19ca-4799-a188-e71d2a97ad7e", "3bc72570-d2d1-4ea9-99e3-260d0f193832", "User", "user" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285d569f-66d2-47e3-8e55-be4157ecfd71", "AQAAAAIAAYagAAAAEM8VGq+9mNbKeJye2BZajU6bFkMtuT1JbiKkfb4kjMJ8lrb5RZC6zgFBcP367yDfDg==", "409771eb-77aa-424a-b764-8bbe10e2f2d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7531de97-1471-4f03-b193-68a094c5f598", "AQAAAAIAAYagAAAAEM4RwFz3Oawh1hSox4GC8+Bja+ShLOithGt96OOrT9+FUdEXt3Dugg5RiVpR3MOQCA==", "2d3fe9dd-62ec-4b39-a2c4-9c08dec70178" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "OrderDate" },
                values: new object[] { null, new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "OrderDate" },
                values: new object[] { null, new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6822));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba521d2-af43-483a-91e1-f1fadbc62c75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de233b96-19ca-4799-a188-e71d2a97ad7e");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76223d5e-02f4-413b-8f1c-1b43cc1ff49e", "17b4543b-5c03-4861-b0ef-f3915b94c0ec", "User", "user" },
                    { "8a633ea7-7db6-453b-b488-a823799cabf0", "79111345-1430-4c95-8972-e86ca43c7928", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e38ddb9e-b264-4b22-8bd7-61222e9a8c56", "AQAAAAIAAYagAAAAEHuMR6KOd5Ba/Bz9khRpxNLfA3RmyaExlGU0MN4M1sWosWIAlg5ULqyncreTGD7bPQ==", "85214b5d-b669-437d-962d-c049e466cae6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4f95a3-b4e1-4434-84c3-34b90dde3db7", "AQAAAAIAAYagAAAAEDqMNbtc9UJRaiU048H6Pk0HQAJTEKD50DjLvIw9JEvBF9KtvHV2p7cBkQ320/q7qQ==", "42ee087e-ddc8-4e61-aba1-912d4e1192ca" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 4, 30, 17, 54, 38, 637, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 4, 30, 17, 54, 38, 637, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 4, 30, 17, 54, 38, 637, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 4, 30, 17, 54, 38, 637, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 4, 30, 17, 54, 38, 637, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 4, 30, 17, 54, 38, 637, DateTimeKind.Local).AddTicks(3844));
        }
    }
}
