using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmailConfirmed",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LoginVia",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatDate", "HashPassword", "IsEmailConfirmed", "LastUpdateDate", "LoginVia", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 21, 15, 47, 39, 337, DateTimeKind.Local).AddTicks(809), "A09A0311E296DA489D63AC3AB2FAD92A97323A322C3B1E03B8BC92A011F49C97B3207C0CF0022595DD2B528FC847A0AA59B07C07E650D143D7883075391C789E", false, new DateTime(2024, 1, 21, 15, 47, 39, 337, DateTimeKind.Local).AddTicks(821), 1, "0684172837", new byte[] { 135, 130, 21, 36, 249, 24, 110, 98, 59, 84, 141, 52, 208, 231, 72, 131, 83, 1, 157, 75, 198, 198, 81, 157, 220, 70, 70, 22, 201, 125, 42, 108, 103, 208, 118, 127, 125, 103, 155, 79, 103, 42, 53, 143, 189, 248, 246, 128, 58, 2, 59, 159, 86, 221, 44, 221, 234, 68, 85, 49, 107, 183, 230, 2 } });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEmailConfirmed",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "LoginVia",
                table: "Accounts");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 50, 34, 309, DateTimeKind.Local).AddTicks(6326), "C29AEC7D70679363A29B599AB5C99F3E9E34E939BE7C86E9C43822AF4D575BF6C494B727E0F40203C391BE165DED5CEFC5832A14CCFDF4939AD7516210983439", new DateTime(2024, 1, 7, 12, 50, 34, 309, DateTimeKind.Local).AddTicks(6346), "0714866451", new byte[] { 112, 226, 232, 125, 242, 153, 234, 180, 167, 38, 251, 145, 243, 111, 1, 4, 113, 206, 182, 187, 123, 135, 89, 194, 198, 34, 32, 168, 254, 171, 210, 144, 226, 117, 52, 140, 97, 210, 83, 165, 117, 190, 40, 59, 139, 28, 18, 1, 14, 45, 152, 14, 121, 196, 146, 222, 3, 194, 98, 178, 168, 102, 216, 5 } });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
