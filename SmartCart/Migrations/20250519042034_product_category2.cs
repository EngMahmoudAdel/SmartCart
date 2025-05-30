using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class product_category2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fed5cc0-28de-4254-9768-9426ba92f4fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63d04bc9-b728-439b-9574-0f3a5dbd1b84");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9362bb88-8239-40be-9d05-8598bdd98340", "28b85255-c431-4ced-93f1-12637289550e", "User", "user" },
                    { "d3149e09-86f3-4ba7-b9a6-9768e4ff9941", "aed81cbb-8a47-4107-b566-f52e1571481d", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abd5ce0-475c-40b7-a08d-43a1db549b7a", "AQAAAAIAAYagAAAAELIWRXj8qaT16y0UsJI2nUiyPRfW+wcUlylKobf79wc02z1oBCJKBf+OcPXHmBI5aA==", "32bc061d-7a07-48e9-83d5-9dfa5741fb35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72296a50-a2ab-4454-97a7-73afa5eef3d1", "AQAAAAIAAYagAAAAEOAJf7jT/6U8LswxhNtEjpX+VxKDB0EEFO7aHRnPjddaRI3SkcVkO3z/yIW5pT6Leg==", "d421f9c9-b747-4c43-b7c4-8f199cc71b79" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 7, 20, 26, 927, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 7, 20, 26, 927, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 7, 20, 26, 927, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 7, 20, 26, 927, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 5, 19, 7, 20, 26, 927, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 5, 19, 7, 20, 26, 927, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/img/51.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 7, 1, "Magic", "/img/53.jpg", "Green-shirt", 200.00m },
                    { 8, 2, "Thats Amazing", "/img/61.jpg", "Gray-Suit", 4000.00m },
                    { 9, 1, "Youth-Flower", "/img/56.jpg", "Flowered-shirt", 400.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9362bb88-8239-40be-9d05-8598bdd98340");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3149e09-86f3-4ba7-b9a6-9768e4ff9941");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fed5cc0-28de-4254-9768-9426ba92f4fc", "f5716f13-811b-4e9e-8e19-87daba460755", "Admin", "admin" },
                    { "63d04bc9-b728-439b-9574-0f3a5dbd1b84", "c00617ae-4d88-433e-91da-4411391308e0", "User", "user" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af570f8c-cf00-494a-9816-81446f9c59e1", "AQAAAAIAAYagAAAAELUcTQUrS61f7Y6hWWFizCJPhk6ckU2tWgt1rVNL5jVGcdyK98LVV0zR9z7hgrb/UQ==", "2772a5fa-bd67-495a-a29a-44b3990da525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0da5c834-d6a4-4780-ad3f-28660995dedc", "AQAAAAIAAYagAAAAEHx5AdiGRvPL2YdATmrDHHYaKzl3x9Q8oofrzc7896Ux+UmnlkqtIEOtcp5R/PN/2A==", "5b03920f-43f7-4b66-a11d-fae5e6a9f403" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 6, 40, 40, 738, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 6, 40, 40, 738, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 6, 40, 40, 738, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 6, 40, 40, 738, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 5, 19, 6, 40, 40, 738, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 5, 19, 6, 40, 40, 738, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/img/153.jpg");
        }
    }
}
