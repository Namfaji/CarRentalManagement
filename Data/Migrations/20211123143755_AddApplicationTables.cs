using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "9003b046-8c70-44c6-bc91-2d2942011e23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d8fa39fe-3f06-4730-aeeb-429c9c57f0a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "326d8c3a-cd12-4266-b9a4-74c7808dc4f4", "AQAAAAEAACcQAAAAEMIxhQtr3EF866RbMwcMnDt9P4ele+BoHtaUba7vRQwb9z63WNs9FwOOPubrpc6ULg==", "6d168900-033b-4f41-8a86-2dadea96e6c8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 270, DateTimeKind.Local).AddTicks(8853), new DateTime(2021, 11, 23, 22, 36, 42, 271, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 271, DateTimeKind.Local).AddTicks(6022), new DateTime(2021, 11, 23, 22, 36, 42, 271, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(3943), new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(3955), new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6296), new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6302), new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6304), new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6306), new DateTime(2021, 11, 23, 22, 36, 42, 272, DateTimeKind.Local).AddTicks(6307) });
        }
    }
}
