using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeModelNameNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
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
                value: "17efdee1-cf15-4ccc-a7c3-59f5e4a76bf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "02a5fdef-6274-4b06-b90e-4063f91d07e3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fc22abb-73a8-4e82-b698-fd20dca274d5", "AQAAAAEAACcQAAAAEPiqTVODV5FnscxtLR2knnARpVnepp3oGXd2lOJXnXmtA0cmxnhUylmSyiJ5llbKRg==", "08e4b1d3-8460-4ebc-aefb-391aa209ff43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02eaeb76-4f0c-486d-8802-fd0d546d3cd1", "AQAAAAEAACcQAAAAEF1yKfX9UdfsaB5rRuc0+2jYlK5vgGiloqrmYt8l0g+cvZjkVRLqrmesuIAl30EjBQ==", "d5bfae57-7d09-4a41-a5af-0d73ff245ffe" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 424, DateTimeKind.Local).AddTicks(4127), new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7696), new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7731), new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7741), new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7750), new DateTime(2021, 8, 10, 20, 17, 8, 429, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(7588), new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8591), new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8615), new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8624), new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8632), new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8640), new DateTime(2021, 8, 10, 20, 17, 8, 432, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(6123), new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7014), new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7036), new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7045), new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7052), new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7060), new DateTime(2021, 8, 10, 20, 17, 8, 433, DateTimeKind.Local).AddTicks(7064) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
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
    }
}
