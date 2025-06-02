using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class ss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8ca068-0b39-4069-a570-86e7e91ed54f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9bd5e561-0ae3-4957-8a00-151384defae9", "270aef86-3bcf-424a-be19-d148d69d65d4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd5e561-0ae3-4957-8a00-151384defae9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "270aef86-3bcf-424a-be19-d148d69d65d4");

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
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 4, 50, 47, 777, DateTimeKind.Local).AddTicks(4856));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9b4a10a-766b-4422-a26b-d8a98b081975");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26532370-9f32-4e80-ba9f-57f26f8fee9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7e8ca068-0b39-4069-a570-86e7e91ed54f", "7f933a71-7298-4e4c-982c-9e2c1928dbce", "User", "user" },
                    { "9bd5e561-0ae3-4957-8a00-151384defae9", "74c0e470-0dd7-4625-b6f2-8a066e587caf", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1eba5b2-3c69-443e-a179-47c65bea11b6", "AQAAAAIAAYagAAAAENz4tukxkiGOpSdZSYXkYfw3cYqd+bhFyjnLUboHj51xhbjrByOIDVXfr1KvfUrWKQ==", "1ea59eb7-4c92-4487-8163-0bb78e625621" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b136d721-ced3-407d-8135-936ddc88f736", "AQAAAAIAAYagAAAAEBg0I0JXs3G+UBNExnmXgBpg0IsZ6XagaH3m+kdIpAPTOhcUv3JNl/pcvJ7it5o2gg==", "bbddaac3-20a5-470f-abef-3a4d2722bb79" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "270aef86-3bcf-424a-be19-d148d69d65d4", 0, "d46e7827-6bf3-4c5b-8b32-1f6a3bbc3594", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFzwXrhAyvFcVQTiiKcHJcXiMsWYfW9wuTqTLeBDdStBMErwewN7gA10tbbcjgL8TA==", null, false, "069931c6-b140-4bcc-9c1c-a9c9802d2ce9", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9bd5e561-0ae3-4957-8a00-151384defae9", "270aef86-3bcf-424a-be19-d148d69d65d4" });
        }
    }
}
