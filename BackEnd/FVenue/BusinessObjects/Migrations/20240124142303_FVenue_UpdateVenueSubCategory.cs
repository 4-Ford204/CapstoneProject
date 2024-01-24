using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class FVenue_UpdateVenueSubCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 24, 21, 23, 3, 608, DateTimeKind.Local).AddTicks(5986), "B8E2C7CD6D3422EC05C05F52FE4F4525331F0786D2DFF8AE28284B1CB73E2C28F8409D6481529C82C8A20D4DEC7EE4BEA96C274209673C8FEEDC5088921AFDD8", new DateTime(2024, 1, 24, 21, 23, 3, 608, DateTimeKind.Local).AddTicks(5999), "0178382448", new byte[] { 255, 7, 83, 158, 20, 101, 201, 185, 71, 244, 251, 0, 109, 246, 72, 201, 213, 36, 157, 100, 108, 2, 45, 68, 188, 193, 222, 53, 214, 159, 169, 158, 60, 45, 197, 252, 66, 189, 69, 247, 113, 24, 165, 225, 121, 158, 206, 155, 87, 120, 163, 115, 91, 130, 243, 212, 48, 15, 197, 185, 93, 250, 129, 85 } });

            migrationBuilder.InsertData(
                table: "VenueSubCategories",
                columns: new[] { "SubCategoryId", "VenueId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 }
                });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 24, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 22, 14, 1, 14, 363, DateTimeKind.Local).AddTicks(7464), "F01EA7AD38B8C0C21695A1511EBC8E9C10F868903D6DA854C495E775EF893DD874AB64035542195866868577EFEC40056B4EBEA8678BE1F7D86B4EFD15F3482E", new DateTime(2024, 1, 22, 14, 1, 14, 363, DateTimeKind.Local).AddTicks(7475), "0432247262", new byte[] { 43, 87, 57, 53, 96, 187, 254, 124, 246, 37, 241, 32, 121, 204, 219, 221, 108, 128, 164, 220, 153, 198, 245, 48, 98, 204, 89, 250, 144, 248, 10, 93, 218, 88, 249, 8, 71, 80, 211, 163, 26, 87, 212, 56, 238, 45, 54, 214, 250, 173, 157, 78, 184, 147, 74, 147, 81, 115, 78, 126, 252, 68, 165, 47 } });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
