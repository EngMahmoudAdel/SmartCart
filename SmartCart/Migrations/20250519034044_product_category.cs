using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class product_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e1553d1-82fd-4703-9ae0-9ab510d8aac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac3b4862-2f61-401d-bb1c-33dd18778aee");

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Casual");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Classic");

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
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 1, "Be Cool", "/img/30.jpg", "Summer-Vibes", 300.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 2, "Oh Suger Dady", "/img/shop_05.jpg", "Suger-Dady-Suit", 5000.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 2, "Black Always win", "/img/36.jpg", "Black-Suit", 2500.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 2, "very Elegent", "/img/shop_07.jpg", "Blue-Jacket", 1000.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Electronics");

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
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 2, "Elegant black suit", "/img/36.jpg", "Black-Suit", 2000.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 1, "Wireless earbuds", "/img/21.jpg", "Air-Bods", 500.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 1, "Smart watch with many features", "/img/23.jpg", "Smart-Watch", 2000.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 1, "HD camera from Canon", "/img/22.jpg", "Hd-Cam-canon", 4000.00m });
        }
    }
}
