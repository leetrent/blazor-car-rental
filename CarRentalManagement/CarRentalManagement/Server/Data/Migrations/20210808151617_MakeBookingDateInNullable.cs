using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MakeBookingDateInNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "16c0188f-d94a-4f69-863b-6166bbb63e3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "af7972d0-e660-4239-a3f3-871df815a87b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a49aa28-37fd-47c7-a63b-de3b67b258df", "AQAAAAEAACcQAAAAEHrHqCuybs8uVGVrVyd4r65AeX/yWn9vRYZjPjpw6zm5+tvKHaDQZ57moRI6SHUEZQ==", "597ed9a4-8898-472b-be75-57a174b6bd2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba61b96-1f00-4bf2-99fa-6b80b0b95376", "AQAAAAEAACcQAAAAEPEXDeCZ4uJMcPuwnCvnR9rDCTRB1B7cl7ObsXXhNOFnhKoJMTJnYwRbnYewxn6vMQ==", "1b3ce720-13a3-40f2-b6a4-025c7455e7fc" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 943, DateTimeKind.Local).AddTicks(9557), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2327), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2348), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2355), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2361), new DateTime(2021, 7, 17, 16, 35, 48, 947, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(1317), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2040), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2056), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2063), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2069), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2075), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8053), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8756), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8773), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8779), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8785), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8791), new DateTime(2021, 7, 17, 16, 35, 48, 949, DateTimeKind.Local).AddTicks(8794) });
        }
    }
}
