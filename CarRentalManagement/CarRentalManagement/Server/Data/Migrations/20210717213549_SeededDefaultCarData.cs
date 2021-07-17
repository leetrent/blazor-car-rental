using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "af7972d0-e660-4239-a3f3-871df815a87b", "Administrator", "ADMINISTRATOR" },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "16c0188f-d94a-4f69-863b-6166bbb63e3b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "0a49aa28-37fd-47c7-a63b-de3b67b258df", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHrHqCuybs8uVGVrVyd4r65AeX/yWn9vRYZjPjpw6zm5+tvKHaDQZ57moRI6SHUEZQ==", null, false, "597ed9a4-8898-472b-be75-57a174b6bd2b", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "fba61b96-1f00-4bf2-99fa-6b80b0b95376", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPEXDeCZ4uJMcPuwnCvnR9rDCTRB1B7cl7ObsXXhNOFnhKoJMTJnYwRbnYewxn6vMQ==", null, false, "1b3ce720-13a3-40f2-b6a4-025c7455e7fc", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "System", new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2327), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2344), "White", "System" },
                    { 3, "System", new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2348), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2351), "Blue", "System" },
                    { 4, "System", new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2355), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2358), "Green", "System" },
                    { 5, "System", new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2361), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2364), "Red", "System" },
                    { 1, "System", new DateTime(2021, 7, 17, 16, 35, 48, 943, DateTimeKind.Local).AddTicks(9557), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(299), "Black", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 6, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2075), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2078), "Nissan", "System" },
                    { 5, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2069), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2072), "Honda", "System" },
                    { 2, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2040), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2052), "Ford", "System" },
                    { 1, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(1317), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(1340), "Chevrolet", "System" },
                    { 3, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2056), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2060), "Dodge", "System" },
                    { 4, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2063), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2066), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8053), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8072), "Malibu", "System" },
                    { 2, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8756), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8769), "Fusion", "System" },
                    { 3, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8773), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8775), "Charger", "System" },
                    { 4, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8779), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8781), "Camry", "System" },
                    { 5, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8785), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8788), "Accord", "System" },
                    { 6, "System", new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8791), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8794), "Altima", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");
        }
    }
}
