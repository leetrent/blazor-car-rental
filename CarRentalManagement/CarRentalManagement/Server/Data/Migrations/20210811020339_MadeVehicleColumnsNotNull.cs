using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeVehicleColumnsNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "57160ab9-ffb8-4302-b5a1-28d63c1fb947");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "fddfe961-aa89-4b9a-ad5c-7bfadbf3bb27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "863034a5-ba25-46e0-bf98-8bffc53b75d2", "AQAAAAEAACcQAAAAEFCzyvdLuboQ9BrWyYWyiRW+N7L4SalQMKlr7gYdlj7Ub7h5hnHtMHmWVvdglYrfBA==", "869342fd-dd3b-4c8e-8868-e5a6f0b8c46d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0074ecd-6984-48e8-a59a-c15dab3e5274", "AQAAAAEAACcQAAAAEHCgSJYWM3NL4uRaMPH98ZNIjBl3Lo5ke2O/cW/7I0vLU5DbO28prwtdXgT0h8WAgA==", "1f0be33d-6e8a-4462-bb76-131e0617f597" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 423, DateTimeKind.Local).AddTicks(5588), new DateTime(2021, 8, 10, 21, 3, 38, 430, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(644), new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(694), new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(708), new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(721), new DateTime(2021, 8, 10, 21, 3, 38, 431, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(7550), new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9334), new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9370), new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9384), new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9398), new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9411), new DateTime(2021, 8, 10, 21, 3, 38, 437, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(1613), new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3090), new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3127), new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3140), new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3154), new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3167), new DateTime(2021, 8, 10, 21, 3, 38, 439, DateTimeKind.Local).AddTicks(3173) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a44b9427-b9bc-46d2-82a5-d3b8a0efc34c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "3e246038-a541-474d-a472-d5d873d4a88c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c889fd91-ed6e-4592-803d-246a7712a771", "AQAAAAEAACcQAAAAELwanBwIFLbvRimJ0W93sIf/LUt4OS7l1FbtEqUxgM82oEdNtUeG3ZRqAa2bTetVNg==", "a902c1be-3688-425d-bb79-8c9ccfbbf81e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c0a3522-9aaf-407a-bf8d-8522b60ea5b0", "AQAAAAEAACcQAAAAEJMEDf+2mLAkge4CYy2b4xOvcgZWfhMtIb0nPDIOzdvnU1lhv9z+Rkoji6WEcmh6/Q==", "288a3f8f-a96c-48e5-b7fd-b3f7b251bd6e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 784, DateTimeKind.Local).AddTicks(9072), new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9460), new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9488), new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9496), new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9503), new DateTime(2021, 8, 10, 20, 59, 40, 788, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(935), new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2241), new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2272), new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2283), new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2293), new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2304), new DateTime(2021, 8, 10, 20, 59, 40, 792, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(2228), new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3440), new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3470), new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3480), new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3492), new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3502), new DateTime(2021, 8, 10, 20, 59, 40, 793, DateTimeKind.Local).AddTicks(3507) });
        }
    }
}
