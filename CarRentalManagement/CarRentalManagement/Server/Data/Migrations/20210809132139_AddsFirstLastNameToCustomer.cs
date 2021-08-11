using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddsFirstLastNameToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6866d65b-4d20-4604-a4d5-abe0b1621e46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b88c235c-2ed4-42df-bff6-eaed3f806cf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8f54bba-1338-411f-b8cd-27b850c2dfa3", "AQAAAAEAACcQAAAAEEvpucC7cenRyqzchfznT24z4SwLmlyu23DEw8bWgopcU+1oJyaUKMJRe3v++Ne2xg==", "b83b3abe-be73-4c73-926c-8d3c329b5d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec940114-9255-4d28-9aad-c50b71fd45a4", "AQAAAAEAACcQAAAAEOzI+g48ZOEJ9IjKLb7d3eiZvGto/urYcCP3tjqr28ccpgY/xW2UycutLbwYyoUwPw==", "c218e31e-17ac-4163-a180-1a346aa5fa72" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 373, DateTimeKind.Local).AddTicks(5625), new DateTime(2021, 8, 9, 8, 21, 38, 375, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(337), new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(343), new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(347), new DateTime(2021, 8, 9, 8, 21, 38, 376, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(4674), new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5203), new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5216), new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5222), new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5227), new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5232), new DateTime(2021, 8, 9, 8, 21, 38, 377, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(656), new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1192), new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1204), new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1209), new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1214), new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1219), new DateTime(2021, 8, 9, 8, 21, 38, 378, DateTimeKind.Local).AddTicks(1221) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "44f45324-c144-46d6-8558-0c51a12cbc6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "3b21e651-4d34-4e38-9989-badbeec906e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad2e0740-0fff-412d-a588-697bc32b70d9", "AQAAAAEAACcQAAAAEC1GWXYodkiwm8t3Z40Hlkgkz4R2M4dQ8Oe4N0NXQbff4LtzQAvOn6VLbAwv1T0BoA==", "fd6251fc-cff6-47ce-b489-c741708e9b01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ae6634-f77a-4f68-9f17-42c42001de82", "AQAAAAEAACcQAAAAEFQ+x2iZVFucEvlb2f6w7rjSl/GPWsctfPQefFctXbHMj7yBVP9STYicesPdH0+rTg==", "01bd65b5-41c1-49ed-bbae-ecc4d9a83776" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 159, DateTimeKind.Local).AddTicks(8007), new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2839), new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2861), new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2868), new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2874), new DateTime(2021, 8, 8, 10, 16, 16, 163, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(2542), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3256), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3274), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3280), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3287), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3293), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(9218), new DateTime(2021, 8, 8, 10, 16, 16, 165, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(17), new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(36), new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(43), new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(50), new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(56), new DateTime(2021, 8, 8, 10, 16, 16, 166, DateTimeKind.Local).AddTicks(59) });
        }
    }
}
