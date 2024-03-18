using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class phuc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeatureImageUrl",
                table: "Venues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9336), "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F", "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9351), "0118138278", new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9421), "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F", "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9422), "0278569488", new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9451), "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F", "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9452), "0163249576", new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9518), "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F", "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9519), "0245747692", new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9581), "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F", "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9582), "0458367938", new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 } });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "FeatureImageUrl", "OpenTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureImageUrl",
                table: "Venues");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4122), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4131), "0732886413", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4184), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4184), "0137944775", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4202), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4202), "0749511416", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4245), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4246), "0671912415", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "HashPassword", "Image", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4262), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4262), "0919164367", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 22, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CloseTime", "OpenTime" },
                values: new object[] { new DateTime(2024, 1, 30, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
