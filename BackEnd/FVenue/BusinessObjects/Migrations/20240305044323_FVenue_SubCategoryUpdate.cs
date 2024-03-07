using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class FVenue_SubCategoryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "VenueSubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "VenueSubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "VenueSubCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "SubCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(1887), "F659D5BF6DF70C163E9C654C78196AB91C5F2EB53F13C5A3303198DCBA50AAECAAAF864BA126D6D06D73D9E09DBEE5A1556EEAF5BE96EB2B39ED78B8591A4F94", new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(1898), "0298723362", new byte[] { 241, 237, 170, 103, 210, 129, 18, 117, 100, 11, 254, 234, 249, 46, 186, 192, 128, 58, 24, 113, 69, 130, 167, 103, 153, 121, 130, 73, 137, 131, 179, 110, 230, 24, 152, 8, 0, 130, 231, 99, 179, 210, 246, 73, 237, 167, 129, 196, 160, 68, 118, 146, 29, 78, 32, 20, 196, 77, 146, 62, 250, 241, 152, 233 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2054), "F659D5BF6DF70C163E9C654C78196AB91C5F2EB53F13C5A3303198DCBA50AAECAAAF864BA126D6D06D73D9E09DBEE5A1556EEAF5BE96EB2B39ED78B8591A4F94", new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2055), "0466911912", new byte[] { 241, 237, 170, 103, 210, 129, 18, 117, 100, 11, 254, 234, 249, 46, 186, 192, 128, 58, 24, 113, 69, 130, 167, 103, 153, 121, 130, 73, 137, 131, 179, 110, 230, 24, 152, 8, 0, 130, 231, 99, 179, 210, 246, 73, 237, 167, 129, 196, 160, 68, 118, 146, 29, 78, 32, 20, 196, 77, 146, 62, 250, 241, 152, 233 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2081), "F659D5BF6DF70C163E9C654C78196AB91C5F2EB53F13C5A3303198DCBA50AAECAAAF864BA126D6D06D73D9E09DBEE5A1556EEAF5BE96EB2B39ED78B8591A4F94", new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2082), "0524733747", new byte[] { 241, 237, 170, 103, 210, 129, 18, 117, 100, 11, 254, 234, 249, 46, 186, 192, 128, 58, 24, 113, 69, 130, 167, 103, 153, 121, 130, 73, 137, 131, 179, 110, 230, 24, 152, 8, 0, 130, 231, 99, 179, 210, 246, 73, 237, 167, 129, 196, 160, 68, 118, 146, 29, 78, 32, 20, 196, 77, 146, 62, 250, 241, 152, 233 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2149), "F659D5BF6DF70C163E9C654C78196AB91C5F2EB53F13C5A3303198DCBA50AAECAAAF864BA126D6D06D73D9E09DBEE5A1556EEAF5BE96EB2B39ED78B8591A4F94", new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2149), "0435312994", new byte[] { 241, 237, 170, 103, 210, 129, 18, 117, 100, 11, 254, 234, 249, 46, 186, 192, 128, 58, 24, 113, 69, 130, 167, 103, 153, 121, 130, 73, 137, 131, 179, 110, 230, 24, 152, 8, 0, 130, 231, 99, 179, 210, 246, 73, 237, 167, 129, 196, 160, 68, 118, 146, 29, 78, 32, 20, 196, 77, 146, 62, 250, 241, 152, 233 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2172), "F659D5BF6DF70C163E9C654C78196AB91C5F2EB53F13C5A3303198DCBA50AAECAAAF864BA126D6D06D73D9E09DBEE5A1556EEAF5BE96EB2B39ED78B8591A4F94", new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(2173), "0963941125", new byte[] { 241, 237, 170, 103, 210, 129, 18, 117, 100, 11, 254, 234, 249, 46, 186, 192, 128, 58, 24, 113, 69, 130, 167, 103, 153, 121, 130, 73, 137, 131, 179, 110, 230, 24, 152, 8, 0, 130, 231, 99, 179, 210, 246, 73, 237, 167, 129, 196, 160, 68, 118, 146, 29, 78, 32, 20, 196, 77, 146, 62, 250, 241, 152, 233 } });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(7763), new DateTime(2024, 3, 5, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(7773), true });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 3, 2, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 4, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 3, 4, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 27, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 2, 27, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 3, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 3, 3, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 20, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 2, 20, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 13, 23, 556, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 3, 5, 11, 13, 23, 556, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 10, 58, 23, 556, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 3, 5, 10, 58, 23, 556, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 8, 43, 23, 556, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 3, 5, 8, 43, 23, 556, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 6, 43, 23, 556, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 3, 5, 6, 43, 23, 556, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 18, 23, 556, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 3, 5, 11, 18, 23, 556, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 41, 23, 556, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 3, 5, 11, 41, 23, 556, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 10, 43, 23, 556, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 3, 5, 10, 43, 23, 556, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 33, 23, 556, DateTimeKind.Local).AddTicks(8544), new DateTime(2024, 3, 5, 11, 33, 23, 556, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 1, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 3, 1, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 43, 23, 556, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 3, 5, 0, 43, 23, 556, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 1, 43, 23, 556, DateTimeKind.Local).AddTicks(8587), new DateTime(2024, 3, 5, 1, 43, 23, 556, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 27, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 2, 27, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 9, 43, 23, 556, DateTimeKind.Local).AddTicks(8613), new DateTime(2024, 3, 5, 9, 43, 23, 556, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 4, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 3, 4, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 10, 43, 23, 556, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 3, 5, 10, 43, 23, 556, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 3, 2, 11, 43, 23, 556, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 7, 43, 23, 556, DateTimeKind.Local).AddTicks(8644), new DateTime(2024, 3, 5, 7, 43, 23, 556, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 28, 23, 556, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 3, 5, 11, 28, 23, 556, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 2, 43, 23, 556, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 3, 5, 2, 43, 23, 556, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 13, 23, 556, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 3, 5, 11, 13, 23, 556, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 10, 53, 23, 556, DateTimeKind.Local).AddTicks(8683), new DateTime(2024, 3, 5, 10, 53, 23, 556, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 10, 43, 23, 556, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 3, 5, 10, 43, 23, 556, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 7, 43, 23, 556, DateTimeKind.Local).AddTicks(8697), new DateTime(2024, 3, 5, 7, 43, 23, 556, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 8, 23, 556, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 3, 5, 11, 8, 23, 556, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 5, 43, 23, 556, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 3, 5, 5, 43, 23, 556, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 5, 9, 43, 23, 556, DateTimeKind.Local).AddTicks(8797), new DateTime(2024, 3, 5, 9, 43, 23, 556, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(792), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(794), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(806), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(807), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(814), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(815), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(822), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(829), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(829), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(849), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(867), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(873), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(874), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(880), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(930), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(937), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(937), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 12 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(955), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 13 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(961), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(962), true });

            migrationBuilder.UpdateData(
                table: "VenueSubCategories",
                keyColumns: new[] { "SubCategoryId", "VenueId" },
                keyValues: new object[] { 1, 14 },
                columns: new[] { "CreateDate", "LastUpdateDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 3, 5, 11, 43, 23, 557, DateTimeKind.Local).AddTicks(969), true });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "VenueSubCategories");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "VenueSubCategories");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "VenueSubCategories");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SubCategories");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5047), "D03F97C02F29C0EB6DFE7A72E193EF7033D2BA9E63EC38D7B24A951EF2B5D21B93CE0C7F202B03388319F6725977BEC10EA3F238D2497EE7A277E8C1FF860BF7", new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5059), "0172722523", new byte[] { 8, 235, 191, 143, 2, 201, 204, 110, 98, 81, 190, 72, 19, 107, 185, 236, 69, 243, 86, 41, 53, 85, 3, 145, 126, 79, 184, 134, 131, 89, 84, 186, 156, 44, 44, 140, 200, 38, 11, 143, 54, 195, 144, 107, 200, 124, 60, 173, 211, 111, 66, 225, 3, 95, 203, 51, 177, 235, 250, 94, 32, 72, 111, 202 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5112), "D03F97C02F29C0EB6DFE7A72E193EF7033D2BA9E63EC38D7B24A951EF2B5D21B93CE0C7F202B03388319F6725977BEC10EA3F238D2497EE7A277E8C1FF860BF7", new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5113), "0445186266", new byte[] { 8, 235, 191, 143, 2, 201, 204, 110, 98, 81, 190, 72, 19, 107, 185, 236, 69, 243, 86, 41, 53, 85, 3, 145, 126, 79, 184, 134, 131, 89, 84, 186, 156, 44, 44, 140, 200, 38, 11, 143, 54, 195, 144, 107, 200, 124, 60, 173, 211, 111, 66, 225, 3, 95, 203, 51, 177, 235, 250, 94, 32, 72, 111, 202 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5136), "D03F97C02F29C0EB6DFE7A72E193EF7033D2BA9E63EC38D7B24A951EF2B5D21B93CE0C7F202B03388319F6725977BEC10EA3F238D2497EE7A277E8C1FF860BF7", new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5136), "0753517734", new byte[] { 8, 235, 191, 143, 2, 201, 204, 110, 98, 81, 190, 72, 19, 107, 185, 236, 69, 243, 86, 41, 53, 85, 3, 145, 126, 79, 184, 134, 131, 89, 84, 186, 156, 44, 44, 140, 200, 38, 11, 143, 54, 195, 144, 107, 200, 124, 60, 173, 211, 111, 66, 225, 3, 95, 203, 51, 177, 235, 250, 94, 32, 72, 111, 202 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5185), "D03F97C02F29C0EB6DFE7A72E193EF7033D2BA9E63EC38D7B24A951EF2B5D21B93CE0C7F202B03388319F6725977BEC10EA3F238D2497EE7A277E8C1FF860BF7", new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5186), "0871213477", new byte[] { 8, 235, 191, 143, 2, 201, 204, 110, 98, 81, 190, 72, 19, 107, 185, 236, 69, 243, 86, 41, 53, 85, 3, 145, 126, 79, 184, 134, 131, 89, 84, 186, 156, 44, 44, 140, 200, 38, 11, 143, 54, 195, 144, 107, 200, 124, 60, 173, 211, 111, 66, 225, 3, 95, 203, 51, 177, 235, 250, 94, 32, 72, 111, 202 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5232), "D03F97C02F29C0EB6DFE7A72E193EF7033D2BA9E63EC38D7B24A951EF2B5D21B93CE0C7F202B03388319F6725977BEC10EA3F238D2497EE7A277E8C1FF860BF7", new DateTime(2024, 3, 2, 21, 5, 40, 838, DateTimeKind.Local).AddTicks(5233), "0937944622", new byte[] { 8, 235, 191, 143, 2, 201, 204, 110, 98, 81, 190, 72, 19, 107, 185, 236, 69, 243, 86, 41, 53, 85, 3, 145, 126, 79, 184, 134, 131, 89, 84, 186, 156, 44, 44, 140, 200, 38, 11, 143, 54, 195, 144, 107, 200, 124, 60, 173, 211, 111, 66, 225, 3, 95, 203, 51, 177, 235, 250, 94, 32, 72, 111, 202 } });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(272), new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 2, 29, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(284), new DateTime(2024, 2, 17, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 20, 40, 839, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 3, 2, 20, 20, 40, 839, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 18, 5, 40, 839, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 3, 2, 18, 5, 40, 839, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 16, 5, 40, 839, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 3, 2, 16, 5, 40, 839, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 40, 40, 839, DateTimeKind.Local).AddTicks(315), new DateTime(2024, 3, 2, 20, 40, 40, 839, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 21, 3, 40, 839, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 3, 2, 21, 3, 40, 839, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 55, 40, 839, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 3, 2, 20, 55, 40, 839, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 27, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 2, 27, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 10, 5, 40, 839, DateTimeKind.Local).AddTicks(375), new DateTime(2024, 3, 2, 10, 5, 40, 839, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 11, 5, 40, 839, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 3, 2, 11, 5, 40, 839, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(407), new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(412), new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 50, 40, 839, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 3, 2, 20, 50, 40, 839, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 12, 5, 40, 839, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 3, 2, 12, 5, 40, 839, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 15, 40, 839, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 3, 2, 20, 15, 40, 839, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 20, 30, 40, 839, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 3, 2, 20, 30, 40, 839, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 15, 5, 40, 839, DateTimeKind.Local).AddTicks(506), new DateTime(2024, 3, 2, 15, 5, 40, 839, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "SubCategoryRequests",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
