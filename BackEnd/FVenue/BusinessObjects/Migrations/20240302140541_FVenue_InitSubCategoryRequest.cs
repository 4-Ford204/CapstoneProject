using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class FVenue_InitSubCategoryRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategoryRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestUserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AdministratorId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoryRequests_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubCategoryRequests_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "SubCategoryRequests",
                columns: new[] { "Id", "AccountId", "AdministratorId", "CategoryId", "CreateDate", "LastUpdateDate", "Name", "RequestUserId", "Status" },
                values: new object[,]
                {
                    { 1, null, 0, 2, new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(251), "Bún đậu mắm tôm", 2, 1 },
                    { 2, null, 0, 4, new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(267), "Karaoke", 3, 1 },
                    { 3, null, 0, 3, new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(272), new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(273), "Nước mía", 4, 1 },
                    { 4, null, 0, 2, new DateTime(2024, 2, 29, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 2, 29, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(279), "Bánh canh ruộng", 3, 1 },
                    { 5, null, 0, 4, new DateTime(2024, 2, 17, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(284), new DateTime(2024, 2, 17, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(284), "Bar", 4, 1 },
                    { 6, null, 0, 1, new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(292), "Rạp phim", 2, 1 },
                    { 7, null, 0, 1, new DateTime(2024, 3, 2, 20, 20, 40, 839, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 3, 2, 20, 20, 40, 839, DateTimeKind.Local).AddTicks(297), "Bảo tàng", 2, 1 },
                    { 8, null, 0, 2, new DateTime(2024, 3, 2, 18, 5, 40, 839, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 3, 2, 18, 5, 40, 839, DateTimeKind.Local).AddTicks(304), "Ốc", 4, 1 },
                    { 9, null, 0, 3, new DateTime(2024, 3, 2, 16, 5, 40, 839, DateTimeKind.Local).AddTicks(309), new DateTime(2024, 3, 2, 16, 5, 40, 839, DateTimeKind.Local).AddTicks(309), "Gelato", 3, 1 },
                    { 10, null, 0, 3, new DateTime(2024, 3, 2, 20, 40, 40, 839, DateTimeKind.Local).AddTicks(315), new DateTime(2024, 3, 2, 20, 40, 40, 839, DateTimeKind.Local).AddTicks(326), "Bingsu", 3, 1 },
                    { 11, null, 0, 3, new DateTime(2024, 3, 2, 21, 3, 40, 839, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 3, 2, 21, 3, 40, 839, DateTimeKind.Local).AddTicks(345), "Sinh tố", 4, 1 },
                    { 12, null, 0, 3, new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(351), "Chè", 2, 1 },
                    { 13, null, 0, 2, new DateTime(2024, 3, 2, 20, 55, 40, 839, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 3, 2, 20, 55, 40, 839, DateTimeKind.Local).AddTicks(364), "Súp cua", 1, 1 },
                    { 14, null, 0, 3, new DateTime(2024, 2, 27, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 2, 27, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(370), "Trà sữa", 2, 1 },
                    { 15, null, 0, 3, new DateTime(2024, 3, 2, 10, 5, 40, 839, DateTimeKind.Local).AddTicks(375), new DateTime(2024, 3, 2, 10, 5, 40, 839, DateTimeKind.Local).AddTicks(376), "Trà sữa pha máy", 3, 1 },
                    { 16, null, 0, 3, new DateTime(2024, 3, 2, 11, 5, 40, 839, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 3, 2, 11, 5, 40, 839, DateTimeKind.Local).AddTicks(384), "Trà sữa ủ lạnh", 2, 1 },
                    { 17, null, 0, 1, new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 2, 24, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(390), "Bida", 4, 1 },
                    { 18, null, 0, 2, new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(396), "Bún chả cá", 3, 1 },
                    { 19, null, 0, 1, new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 3, 1, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(402), "Quán net", 3, 1 },
                    { 20, null, 0, 2, new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(407), new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(407), "Ẩm thực Thái Lan", 1, 1 },
                    { 21, null, 0, 1, new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(412), new DateTime(2024, 2, 28, 21, 5, 40, 839, DateTimeKind.Local).AddTicks(413), "Spa", 2, 1 },
                    { 22, null, 0, 3, new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(418), "Kem bơ", 1, 1 },
                    { 23, null, 0, 2, new DateTime(2024, 3, 2, 20, 50, 40, 839, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 3, 2, 20, 50, 40, 839, DateTimeKind.Local).AddTicks(423), "Cơm gà", 3, 1 },
                    { 24, null, 0, 2, new DateTime(2024, 3, 2, 12, 5, 40, 839, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 3, 2, 12, 5, 40, 839, DateTimeKind.Local).AddTicks(434), "Pizza", 2, 1 },
                    { 25, null, 0, 2, new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 3, 2, 20, 35, 40, 839, DateTimeKind.Local).AddTicks(439), "Bánh tráng nướng", 4, 1 },
                    { 26, null, 0, 3, new DateTime(2024, 3, 2, 20, 15, 40, 839, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 3, 2, 20, 15, 40, 839, DateTimeKind.Local).AddTicks(445), "Thức uống detox", 3, 1 },
                    { 27, null, 0, 2, new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 3, 2, 20, 5, 40, 839, DateTimeKind.Local).AddTicks(450), "Đồ chay", 3, 1 },
                    { 28, null, 0, 2, new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 3, 2, 17, 5, 40, 839, DateTimeKind.Local).AddTicks(455), "Bún bò", 3, 1 },
                    { 29, null, 0, 2, new DateTime(2024, 3, 2, 20, 30, 40, 839, DateTimeKind.Local).AddTicks(460), new DateTime(2024, 3, 2, 20, 30, 40, 839, DateTimeKind.Local).AddTicks(461), "Hải sản tươi sống", 4, 1 },
                    { 30, null, 0, 3, new DateTime(2024, 3, 2, 15, 5, 40, 839, DateTimeKind.Local).AddTicks(506), new DateTime(2024, 3, 2, 15, 5, 40, 839, DateTimeKind.Local).AddTicks(507), "Nước ép trái cây", 2, 1 },
                    { 31, null, 0, 2, new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 3, 2, 19, 5, 40, 839, DateTimeKind.Local).AddTicks(546), "Chân gà nướng", 1, 1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryRequests_AccountId",
                table: "SubCategoryRequests",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryRequests_CategoryId",
                table: "SubCategoryRequests",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategoryRequests");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4122), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4131), "0732886413", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4184), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4184), "0137944775", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4202), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4202), "0749511416", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4245), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4246), "0671912415", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "HashPassword", "LastUpdateDate", "PhoneNumber", "SaltPassword" },
                values: new object[] { new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4262), "5D3D421729DBC05240667F184768BC3750C844F44529EA3A248E55DD3062CE81BD7CE813C1EEC49F1134552DA8C71F4ABDC1A1A7FBAA85EA5DC76D6A24A10C3A", new DateTime(2024, 1, 30, 12, 41, 2, 563, DateTimeKind.Local).AddTicks(4262), "0919164367", new byte[] { 186, 205, 154, 77, 34, 205, 80, 136, 148, 249, 159, 131, 85, 180, 182, 75, 133, 108, 67, 229, 3, 239, 252, 254, 56, 237, 109, 111, 156, 146, 221, 84, 164, 68, 73, 206, 138, 49, 151, 60, 30, 14, 220, 178, 35, 182, 239, 189, 17, 92, 158, 110, 170, 182, 155, 141, 87, 28, 102, 25, 240, 242, 152, 131 } });

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
