using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "31491548-cfcf-4971-b3c8-f1e725964a21", "195904c6-cb42-46c7-b73b-537ff3b04364", "Admin", "admin" },
                    { "42e56bc9-baff-49c6-b592-ef40d657ad7f", "c3f76788-0d02-4fea-b7b0-df62d7dd4baf", "User", "user" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78280117-81f3-4b77-9cf6-889cc796b302", "AQAAAAIAAYagAAAAEKX2rDI90JA1bVpdAS6qz0K0jxI88Lq5LW5N4FVYaeFhX7k81EG92DnjK/bI2Gblug==", "faa87a0c-9168-48ef-803b-8c0876d9853f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ec82c18-2133-437a-938c-2709fef57dc1", "AQAAAAIAAYagAAAAEJaFcn6tXguWvXN9Fxt/801ADE/4zGex1FwP/yRAJeLqD1csUtHkmYCE7x2xP9m+nQ==", "490d8530-cb43-4796-8818-33399d4830fe" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Clothes");

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 4, 13, 14, 458, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 4, 13, 14, 458, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 4, 13, 14, 458, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 4, 13, 14, 458, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 5, 19, 4, 13, 14, 458, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 5, 19, 4, 13, 14, 458, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImagePath", "Name" },
                values: new object[] { 2, "/img/153.jpg", "Man-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImagePath", "Name", "Price" },
                values: new object[] { "/img/36.jpg", "Black-Suit", 2000.00m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 2, "/img/11.jpg", "jeans-shirt", 450.00m },
                    { 4, 1, "/img/21.jpg", "Air-Bods", 500.00m },
                    { 5, 1, "/img/23.jpg", "Smart-Watch", 2000.00m },
                    { 6, 1, "/img/22.jpg", "Hd-Cam-canon", 4000.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31491548-cfcf-4971-b3c8-f1e725964a21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42e56bc9-baff-49c6-b592-ef40d657ad7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Furniture");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImagePath", "Name" },
                values: new object[] { 1, null, "Smartphone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImagePath", "Name", "Price" },
                values: new object[] { null, "Table", 100.00m });
        }
    }
}
