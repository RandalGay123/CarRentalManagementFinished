using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "12ca8b2d-e7b0-4afa-97b2-343c6310aec0", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFFIIYXx4vjHeygUVd8N5ZN0fftYlC84gYjZfrxbbepgmjXutxrIX23qhEEyKmvE9w==", null, false, "799ca3cf-e618-4399-8eca-39cc625fd159", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8069), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8406), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8407), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8411), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8578), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8578), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8580), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8580), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8582), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8583), new DateTime(2023, 11, 28, 11, 57, 59, 366, DateTimeKind.Local).AddTicks(8583), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 56, 30, 480, DateTimeKind.Local).AddTicks(6673), new DateTime(2023, 11, 28, 11, 56, 30, 480, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 11, 56, 30, 480, DateTimeKind.Local).AddTicks(6689), new DateTime(2023, 11, 28, 11, 56, 30, 480, DateTimeKind.Local).AddTicks(6690) });
        }
    }
}
