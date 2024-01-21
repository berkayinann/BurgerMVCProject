using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class burgermvcDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd399d9f-b343-44e7-bc9b-9380a8fb204a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdcbc75f-fb44-4f71-871d-49c335ded8e7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Addresses", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "83bcdd6f-fe6d-48cc-a8af-f3cde0fea281", 0, null, "74977b27-3640-4cfd-aced-4ae22dd16caf", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", "P@ssword!", "AQAAAAEAACcQAAAAELlHA0OI2fNYXhJ4f0obL85N/JXSZsKlD8uTjR7uQX8f+a60nWHAcYy8xeynBvVlHQ==", null, false, "", false, "John_Doe" },
                    { "e8e6554a-d02f-4f39-b137-f0fb2c88491e", 0, null, "29e31c86-a6ce-4ad7-b097-c368530d1526", "admin@example.com", true, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Qwe.123", "AQAAAAEAACcQAAAAEHJ1zhDNnL0mftjhblrRBRSsXwxkUf7vPpiq3ZqtUYydpiVKJG1pNqyOWPYxJFxPyw==", null, false, "", false, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 17, 21, 54, 175, DateTimeKind.Local).AddTicks(5762));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83bcdd6f-fe6d-48cc-a8af-f3cde0fea281");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8e6554a-d02f-4f39-b137-f0fb2c88491e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Addresses", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cd399d9f-b343-44e7-bc9b-9380a8fb204a", 0, null, "9b30c1c0-c1a9-44ba-9eee-85e9a7616f6c", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", "P@ssword!", "AQAAAAEAACcQAAAAEEDXEY3f6Ms1q3Y9K0ivNJMUc3ssRrKCnjlYV/MhH3BQ4L6cPT3gbO6U3OU/1fYxvQ==", null, false, "", false, "John_Doe" },
                    { "fdcbc75f-fb44-4f71-871d-49c335ded8e7", 0, null, "4d9d148d-0b3c-4633-ae7e-ef39c42802c5", "admin@example.com", true, "Admin", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "Qwe.123", "AQAAAAEAACcQAAAAEDjaGPONJ6OVz9g+30jqCX6eBSoK4ykwBz6BMC6xPqDyaXOk1SieJquDGRiIkx1bUg==", null, false, "", false, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Extra Products",
                keyColumn: "ExtraProductId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 20, 11, 21, 10, 184, DateTimeKind.Local).AddTicks(8610));
        }
    }
}
