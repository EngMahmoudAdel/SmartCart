using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class product_Description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31491548-cfcf-4971-b3c8-f1e725964a21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42e56bc9-baff-49c6-b592-ef40d657ad7f");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e1553d1-82fd-4703-9ae0-9ab510d8aac1", "3d0429a1-63a9-43a6-adcc-4a36b7bcc0c3", "User", "user" },
                    { "ac3b4862-2f61-401d-bb1c-33dd18778aee", "be1defa9-19bb-404c-8bbc-092168708d77", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2d9f1e8-c50e-4e3e-8c82-00de60895ce5", "AQAAAAIAAYagAAAAEGj1B8BfICDQ41bkPCKJY8AiaGxmejDsD8GjM6z+3kMf9UepmUhC9jIEGNSWwZEdVQ==", "3dd8fa84-1e1d-4b7a-b12a-cc1125b39bd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d625277-8c74-43d3-9545-90cbde947beb", "AQAAAAIAAYagAAAAEDDa8rIrMrxUezYjrnrU0HVhtpQt0gwevxOqIBCJjTwBSxLy05q5rwRr5kkPC8ZPHw==", "ea42ec44-7140-4e73-931d-e3dcff074232" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 6, 25, 52, 958, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 5, 19, 6, 25, 52, 958, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 6, 25, 52, 958, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 5, 19, 6, 25, 52, 958, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 5, 19, 6, 25, 52, 958, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 5, 19, 6, 25, 52, 958, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Men's casual shirt");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Elegant black suit");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Comfortable jeans shirt");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Wireless earbuds");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Smart watch with many features");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "HD camera from Canon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e1553d1-82fd-4703-9ae0-9ab510d8aac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac3b4862-2f61-401d-bb1c-33dd18778aee");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

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
        }
    }
}
