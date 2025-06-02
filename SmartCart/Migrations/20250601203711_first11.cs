using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartCart.Migrations
{
    /// <inheritdoc />
    public partial class first11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "061cd6d2-ad35-46c4-a783-24dbdfcff108");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ec72c90-0a79-4600-91b1-70882394706f");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "061cd6d2-ad35-46c4-a783-24dbdfcff108", "40c7f015-f360-4e8c-9b66-6b2a56e319f2", "User", "user" },
                    { "5ec72c90-0a79-4600-91b1-70882394706f", "399b8611-3086-425f-bfc2-f938d64a62d4", "Admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee1c3a7c-799b-439b-9d4f-b5f7ec1a9a69", "AQAAAAIAAYagAAAAEK6erccoDDFTaP7KCQOOfFrQdhdeZhc1Pt4gu5pH9m7uGoHGa/5Jd/fMMpfIrsP4SA==", "3ce72b9a-c043-4bc6-8f0c-2e0b23bd6f49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32642b66-a419-40aa-8188-d7c127729b01", "AQAAAAIAAYagAAAAEK5L0xuiXYaxiD3K2krl7yQIg6oQLcEac4PjJEIDvPtN7OdZi7pd5NUxdFjsH3VC9A==", "9bde89c5-decc-4a3a-abfb-6c1421756821" });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentDate",
                value: new DateTime(2025, 6, 1, 23, 20, 6, 186, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SentDate",
                value: new DateTime(2025, 6, 1, 23, 20, 6, 186, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 23, 20, 6, 186, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2025, 6, 1, 23, 20, 6, 186, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 1, 23, 20, 6, 186, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 6, 1, 23, 20, 6, 186, DateTimeKind.Local).AddTicks(5323));
        }
    }
}
