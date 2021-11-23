using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "399da2ee-67bf-47ce-978c-59eba59a9a7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "57d1883a-b0a9-4e19-a4d6-0db55452d2a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1efc16bd-e1e7-49e7-bd95-28f3935bcd01", "AQAAAAEAACcQAAAAEHHG6Wb+xlaAmmockuqWgY0rSvUVqkgTdHU3URCcLIJvOWjMkK+UnY2Ob5f0S40sVA==", "402e2bb0-738a-4c01-aa88-3ace0b87267d" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 570, DateTimeKind.Local).AddTicks(4054), new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(846), new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(8579), new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(8589), new DateTime(2021, 11, 23, 22, 38, 46, 571, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(991), new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(998), new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(1000), new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(1002), new DateTime(2021, 11, 23, 22, 38, 46, 572, DateTimeKind.Local).AddTicks(1003) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "05ddd636-683a-43a4-8459-c36d72fdd031");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "cf2ab55a-e2cf-4541-a382-81c68b5b6dbf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f105a5d-2b07-4a59-bdcc-6e3c1dc2ed6a", "AQAAAAEAACcQAAAAEEIRzL3dWocrChwLxeutliNPF4J0jyxz3ee7kWcY57cFIys91QIvFvYAwNm76JTF4Q==", "7b406548-c32d-42f9-ab6c-815bec19fa66" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 38, DateTimeKind.Local).AddTicks(4333), new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(1393), new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(9181), new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(9192), new DateTime(2021, 11, 23, 22, 37, 55, 39, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1424), new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1430), new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1432), new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1434), new DateTime(2021, 11, 23, 22, 37, 55, 40, DateTimeKind.Local).AddTicks(1435) });
        }
    }
}
