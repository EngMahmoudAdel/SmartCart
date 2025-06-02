using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class s4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec08aa83-24ff-46f9-b704-321d6196c3c1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9b4a10a-766b-4422-a26b-d8a98b081975", "26532370-9f32-4e80-ba9f-57f26f8fee9a" });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9b4a10a-766b-4422-a26b-d8a98b081975");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26532370-9f32-4e80-ba9f-57f26f8fee9a");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13d293fd-9ed5-441c-8830-d22b5f553648", "b99b6ae3-b693-42d1-a418-b722a26a9f2c", "User", "user" },
                    { "ea7b29a9-df59-423d-8185-a18896333bde", "b410c8b8-0a32-4b55-ae3e-303035d82f79", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d99399a9-23d8-4393-b38e-57d939a0d3da", "AQAAAAIAAYagAAAAEIFFQfy3McrBuuEOxSkKQd1atLi7Lh1GAPm4qowWd6Um/aZETvXMZBd5GNXHienbtw==", "f8ba9e12-67ee-4748-aa3a-468270f13aaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "266d8e7e-8ca1-4dfd-bb05-0e3747720e6e", "AQAAAAIAAYagAAAAEABh3zDLCrMyH+jgVtbSf8FXGtV60z/NAtkVpYun1/Jna89aS4yiQZo69GB9pFWaCA==", "a8411d68-3862-456a-b318-2465c8370ac3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b602650-bc9f-4c81-97bb-ced5f313dd1a", 0, "8d212e9f-5540-4da1-b463-3f0965f5343a", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDlj9tXgmJZDnIxf6ButAhmnIanNqKiXZ9YA/khU5UBxxRRzyE3idTZpoIxMZEZAtA==", null, false, "8b8add0f-c8af-49bb-b4db-0ad3730b7ce1", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 6, 2, 4, 59, 57, 465, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 6, 2, 4, 59, 57, 465, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "OrderDate", "Phone", "Status", "TotalAmount", "UserId" },
                values: new object[] { "123 Test St, Cairo", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01000000000", "Pending", 100.00m, "user-123" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 2, 4, 59, 57, 465, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 2, 4, 59, 57, 465, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea7b29a9-df59-423d-8185-a18896333bde", "8b602650-bc9f-4c81-97bb-ced5f313dd1a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d293fd-9ed5-441c-8830-d22b5f553648");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea7b29a9-df59-423d-8185-a18896333bde", "8b602650-bc9f-4c81-97bb-ced5f313dd1a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea7b29a9-df59-423d-8185-a18896333bde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b602650-bc9f-4c81-97bb-ced5f313dd1a");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec08aa83-24ff-46f9-b704-321d6196c3c1", "a3c7c4f9-79c9-4f49-bf7a-a5579d1234f8", "User", "user" },
                    { "f9b4a10a-766b-4422-a26b-d8a98b081975", "141c65da-6833-4d1f-ab63-8ae1828f99f2", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9915901d-e11c-4f0f-a093-2ea6e329bc3b", "AQAAAAIAAYagAAAAEDel5RcSeeUBUj29KSh97YE0AyhuHCGCRCdOL1KCHVOKudKfp95GUeLO3Uhv+vLlNw==", "9bef24b1-d04a-4bf6-be7f-66cd3b2ef822" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6249dd18-26e6-40b8-8882-d7f922c49e70", "AQAAAAIAAYagAAAAEGxqB9vxTBxZTUAkgpjbdX8aGTMhmGMVNVngPgew4+fp3yY5RswBg8qGVRwhMQrWZQ==", "3adb14aa-40ca-4b10-8bd4-4cb7342b0b4b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "26532370-9f32-4e80-ba9f-57f26f8fee9a", 0, "3cff7b39-c795-4dca-8dc1-3e59ff41eaca", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAOsHBEdjD4nzkbsOEVPD7BRN46GAi4PplALV3c7k4y+7Jwa+Iw9xQRMldr2wB/eGg==", null, false, "5fb55f0a-d754-45be-b23e-09a18de72d04", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "OrderDate", "Phone", "TotalAmount", "UserId" },
                values: new object[] { null, new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(4846), null, 1000.00m, "1" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "OrderDate", "Phone", "TotalAmount", "UserId" },
                values: new object[] { 2, null, new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(4856), null, 200.00m, "2" });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f9b4a10a-766b-4422-a26b-d8a98b081975", "26532370-9f32-4e80-ba9f-57f26f8fee9a" });
        }
    }
}
