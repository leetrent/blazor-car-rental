using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddsValidationRulesToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c5cf575d-8236-4d3b-9362-b99157d2ada0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "1f9ad2a8-2b0d-41af-b48d-0eb4f520728a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6444430b-895e-4a06-86ac-4ee89c0e99a6", "AQAAAAEAACcQAAAAENLwGGsnpw1HmItLeRuVATc5keI8AbWVFc4jG7Hn9FzmXkW57SzTotYOGVNlVzepdw==", "2ad4eb12-6277-498a-88bf-ada31ad4ffc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee6c1cda-17a9-495c-8cef-a7897f15d4fe", "AQAAAAEAACcQAAAAEPpXzCoyXT5qBO3tvi/acyEbsVG9zhx0KM8BV5gamClorY9nrxutETn/JhutoQSnmg==", "587fc12e-9fd5-4eae-8fbe-69f9c5fd09f4" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 489, DateTimeKind.Local).AddTicks(4788), new DateTime(2021, 8, 9, 8, 42, 16, 491, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(565), new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(581), new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(586), new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(590), new DateTime(2021, 8, 9, 8, 42, 16, 492, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5035), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5571), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5583), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5588), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5593), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5597), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(9800), new DateTime(2021, 8, 9, 8, 42, 16, 493, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(318), new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(331), new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(335), new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(340), new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(345), new DateTime(2021, 8, 9, 8, 42, 16, 494, DateTimeKind.Local).AddTicks(347) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
