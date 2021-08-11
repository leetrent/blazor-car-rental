using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeMakeNameNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
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
                value: "a6633de8-8e73-4148-b06e-dd2de587b3aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b8ffcc3f-9397-4c5a-b0cb-e168823a6067");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45587e14-4541-49b0-80d4-0710976f310a", "AQAAAAEAACcQAAAAEH07Nw64aWyXXAsCNpQVgFe5ujW0UFdw8XcmQpYb9spMtyJDr3q9MqVIL8wLpUtsQg==", "20a61752-94b0-4108-9169-79b50b35bd23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0b7b71a-4257-4ab1-a0d8-637f5e92ff09", "AQAAAAEAACcQAAAAEHSaCyIJjlTjOq51ZzpkvTLkbf0T/dWJbI7YHqLpXjNBVChMFRiG++BCOISp5arvYQ==", "f61d0aed-c0aa-4b25-94e0-70f5c8d25b70" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 968, DateTimeKind.Local).AddTicks(7479), new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5599), new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5635), new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5644), new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5653), new DateTime(2021, 8, 10, 20, 11, 3, 973, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(6803), new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7859), new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7881), new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7889), new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7897), new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7905), new DateTime(2021, 8, 10, 20, 11, 3, 976, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(7548), new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8754), new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8779), new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8789), new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8798), new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8807), new DateTime(2021, 8, 10, 20, 11, 3, 977, DateTimeKind.Local).AddTicks(8812) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
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
    }
}
