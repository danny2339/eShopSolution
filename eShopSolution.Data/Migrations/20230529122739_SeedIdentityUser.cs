using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e2307d63-6abc-449f-83a5-81a659c39470"), "a9cd3d4c-c2a6-4cdb-b743-b4024771eea9", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e2307d63-6abc-449f-83a5-81a659c39470"), new Guid("56104016-1c7f-46f2-9316-445bbf443dce") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("56104016-1c7f-46f2-9316-445bbf443dce"), 0, "65fc307f-df3e-423d-8465-9fabdc958986", new DateTime(2001, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Tan", "Ngo", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEKUi9J1tujhKz6sqlUuUNDYEEKtne/DjIA88vzkQMkNNlUBD1GO1bkAiLD+bVE2SNg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 29, 19, 27, 39, 318, DateTimeKind.Local).AddTicks(2617));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e2307d63-6abc-449f-83a5-81a659c39470"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e2307d63-6abc-449f-83a5-81a659c39470"), new Guid("56104016-1c7f-46f2-9316-445bbf443dce") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("56104016-1c7f-46f2-9316-445bbf443dce"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 5, 29, 19, 1, 21, 421, DateTimeKind.Local).AddTicks(8003));
        }
    }
}
