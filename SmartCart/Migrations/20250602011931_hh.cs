using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class hh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f7e93fa-ef28-4451-a8f1-3c9214ecaf8d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6bf6a88c-55e7-4f67-80b2-512c0089cd0e", "5315e7f5-0ae6-46e4-8d89-07a85ffbe89a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bf6a88c-55e7-4f67-80b2-512c0089cd0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5315e7f5-0ae6-46e4-8d89-07a85ffbe89a");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "OrderDate", "Phone" },
                values: new object[] { new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8646), null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "Phone" },
                values: new object[] { new DateTime(2025, 6, 2, 4, 19, 26, 241, DateTimeKind.Local).AddTicks(8686), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6bf6a88c-55e7-4f67-80b2-512c0089cd0e", "3c27940f-db7c-45d3-8670-09912b7a37f3", "Admin", "admin" },
                    { "9f7e93fa-ef28-4451-a8f1-3c9214ecaf8d", "7070e3e7-2bea-4913-8d13-0a5067097306", "User", "user" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "787f8800-27d7-47f2-bed4-03e2736d6cde", "AQAAAAIAAYagAAAAEIrE3NPp75x5HIlDQCzfontU3XeNZG7/v0rRQk61b/Da0D9hxSoidd0uoJlkXdfOyw==", "3932d797-e3a5-45a1-8c55-877ccbad88a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21fbd334-d9cf-493e-81b5-b7e0f1063edc", "AQAAAAIAAYagAAAAEF1SLE4lF+lrOAzuxcP0V5QtkpNdpfrk2SSXB4OgO2DoEXoVOxfvNono4aMUEPIIRw==", "1e2d149c-84cd-426d-9268-885453d52405" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5315e7f5-0ae6-46e4-8d89-07a85ffbe89a", 0, "aff762bd-8ce5-4d1a-bc98-4e4fe24d6789", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDh5qLpOhzKEFl1fBXGZKjt5C45Q/+f3Fu7OUTwgOgdty63vAKs4tt7mpxWnz+XH+Q==", null, false, "fbea1f8d-44d0-4d34-a22f-12ce09694aa5", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 6, 1, 23, 37, 7, 817, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 6, 1, 23, 37, 7, 817, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 23, 37, 7, 817, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 23, 37, 7, 817, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 1, 23, 37, 7, 817, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 1, 23, 37, 7, 817, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6bf6a88c-55e7-4f67-80b2-512c0089cd0e", "5315e7f5-0ae6-46e4-8d89-07a85ffbe89a" });
        }
    }
}
