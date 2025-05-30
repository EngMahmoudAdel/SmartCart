using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba521d2-af43-483a-91e1-f1fadbc62c75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de233b96-19ca-4799-a188-e71d2a97ad7e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a9e4d82-1130-49f9-8d6e-796fdbb6def4", "40d3ff38-73b3-4c64-b04e-42c16789c37e", "Admin", "admin" },
                    { "3e35ca9d-a52c-4a0f-a245-a7369068bcc1", "6672bc70-f07b-4b95-9e44-53f739f2252e", "User", "user" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7babf05b-f05e-431f-a24a-221907eeee79", "AQAAAAIAAYagAAAAEGQi7T9pgMntfG0RTT7yNsjdH/geiRr9CbhzdNwEwN1YYNgGt0EsTMq38AI7oT+e8A==", "495b7a57-042c-4ca2-ab9d-eb58eb76a440" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "797379fd-dd43-412e-92b4-692b9302c10e", "AQAAAAIAAYagAAAAEDwgTxwu3eKAQGdobk6y+9LmCcuQQbbDukAIJVydajccK3DH7wAZuLtfDYBvblyZMA==", "7f8cfa47-f5c9-44d9-893e-af839b156961" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 5, 1, 2, 58, 25, 323, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 5, 1, 2, 58, 25, 323, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 1, 2, 58, 25, 323, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 1, 2, 58, 25, 323, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 5, 1, 2, 58, 25, 323, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 5, 1, 2, 58, 25, 323, DateTimeKind.Local).AddTicks(483));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a9e4d82-1130-49f9-8d6e-796fdbb6def4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e35ca9d-a52c-4a0f-a245-a7369068bcc1");

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
                column: "OrderDate",
                value: new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 4, 30, 18, 1, 7, 826, DateTimeKind.Local).AddTicks(6499));

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
    }
}
