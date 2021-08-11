using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MakesColourNameRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(30)",
                maxLength: 30,
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
                value: "19494fa7-0de6-45ff-86a5-502a9a0f5a4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b332b3bc-8208-4998-bf76-40383c70ce2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d080c945-f19f-445c-8d71-4300a7eaf1e3", "AQAAAAEAACcQAAAAEIynMIqYMvAiNuQiM0t9p6nS/UGZtsBhkdfrcAvHBWqrd774iCNPCcMCCPIaElCETQ==", "c27bcdd4-989b-4357-a28c-7e29876f30bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0461437a-008b-4dc3-8269-09ce7f3d664a", "AQAAAAEAACcQAAAAEOx2JzMeuwvZ2BC6ZABGSOuddS4V/gbkeO2UXB6n8RXb4LB6yEzWWjp2plVYJBoBDA==", "425a82af-e49d-4fc5-8787-7bcc4fd45efa" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 331, DateTimeKind.Local).AddTicks(4371), new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6854), new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6905), new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6918), new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6931), new DateTime(2021, 8, 10, 7, 32, 55, 338, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 342, DateTimeKind.Local).AddTicks(8944), new DateTime(2021, 8, 10, 7, 32, 55, 342, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(691), new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(730), new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(744), new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(757), new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(770), new DateTime(2021, 8, 10, 7, 32, 55, 343, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(3646), new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5277), new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5529), new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5549), new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5562), new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5575), new DateTime(2021, 8, 10, 7, 32, 55, 344, DateTimeKind.Local).AddTicks(5581) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

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
    }
}
