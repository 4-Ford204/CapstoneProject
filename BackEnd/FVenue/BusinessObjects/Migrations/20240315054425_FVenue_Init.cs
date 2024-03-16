using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class FVenue_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaltPassword = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    HashPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoginMethod = table.Column<int>(type: "int", nullable: false),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "VNPAYPayments",
                columns: table => new
                {
                    PaymentId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VNPAYPayments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_VNPAYPayments_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wards_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<int>(type: "int", nullable: false),
                    GeoLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LowerPrice = table.Column<float>(type: "real", nullable: false),
                    UpperPrice = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venues_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venues_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenueSubCategories",
                columns: table => new
                {
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueSubCategories", x => new { x.VenueId, x.SubCategoryId });
                    table.ForeignKey(
                        name: "FK_VenueSubCategories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VenueSubCategories_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Địa điểm giải trí" },
                    { 2, "Ẩm thực" },
                    { 3, "Thức uống" },
                    { 4, "Giải trí về đêm" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Việt Nam" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "VenueManager" },
                    { 3, "User" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "BirthDay", "CreateDate", "Email", "FirstName", "FullName", "Gender", "HashPassword", "Image", "IsEmailConfirmed", "LastName", "LastUpdateDate", "LoginMethod", "PhoneNumber", "RoleId", "SaltPassword", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1222), "huynhduy20042002@gmail.com", "Duy", "Duy Lê Tự Huỳnh", true, "0744532E6738DB9F3F56CE11DE164690D938E1F94BD2E464A33D9466C4A5883DA830779521A648D1CE707949FF9D1C007069070440CBB8491EC1ED2783E75E78", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Lê Tự Huỳnh", new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1234), 1, "0939115828", 1, new byte[] { 67, 197, 12, 171, 95, 16, 180, 218, 226, 114, 27, 174, 189, 182, 196, 106, 5, 145, 196, 59, 80, 232, 187, 88, 204, 123, 13, 118, 124, 244, 123, 139, 43, 194, 166, 156, 149, 228, 56, 7, 58, 67, 202, 74, 122, 17, 212, 174, 188, 20, 234, 76, 148, 113, 10, 224, 187, 181, 157, 8, 166, 47, 26, 234 }, true },
                    { 2, new DateTime(2002, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1282), "phuchvde160270@fpt.edu.vn", "Phúc", "Phúc Hồ Văn", true, "0744532E6738DB9F3F56CE11DE164690D938E1F94BD2E464A33D9466C4A5883DA830779521A648D1CE707949FF9D1C007069070440CBB8491EC1ED2783E75E78", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Hồ Văn", new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1282), 1, "0428481941", 1, new byte[] { 67, 197, 12, 171, 95, 16, 180, 218, 226, 114, 27, 174, 189, 182, 196, 106, 5, 145, 196, 59, 80, 232, 187, 88, 204, 123, 13, 118, 124, 244, 123, 139, 43, 194, 166, 156, 149, 228, 56, 7, 58, 67, 202, 74, 122, 17, 212, 174, 188, 20, 234, 76, 148, 113, 10, 224, 187, 181, 157, 8, 166, 47, 26, 234 }, true },
                    { 3, new DateTime(2000, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1302), "hungnhde160214@fpt.edu.vn", "Hùng", "Hùng Nguyễn Huy", true, "0744532E6738DB9F3F56CE11DE164690D938E1F94BD2E464A33D9466C4A5883DA830779521A648D1CE707949FF9D1C007069070440CBB8491EC1ED2783E75E78", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Nguyễn Huy", new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1303), 1, "0957375589", 1, new byte[] { 67, 197, 12, 171, 95, 16, 180, 218, 226, 114, 27, 174, 189, 182, 196, 106, 5, 145, 196, 59, 80, 232, 187, 88, 204, 123, 13, 118, 124, 244, 123, 139, 43, 194, 166, 156, 149, 228, 56, 7, 58, 67, 202, 74, 122, 17, 212, 174, 188, 20, 234, 76, 148, 113, 10, 224, 187, 181, 157, 8, 166, 47, 26, 234 }, true },
                    { 4, new DateTime(2002, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1373), "trilmde160230@fpt.edu.vn", "Trí", "Trí Lê Minh", true, "0744532E6738DB9F3F56CE11DE164690D938E1F94BD2E464A33D9466C4A5883DA830779521A648D1CE707949FF9D1C007069070440CBB8491EC1ED2783E75E78", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Lê Minh", new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1373), 1, "0393757344", 1, new byte[] { 67, 197, 12, 171, 95, 16, 180, 218, 226, 114, 27, 174, 189, 182, 196, 106, 5, 145, 196, 59, 80, 232, 187, 88, 204, 123, 13, 118, 124, 244, 123, 139, 43, 194, 166, 156, 149, 228, 56, 7, 58, 67, 202, 74, 122, 17, 212, 174, 188, 20, 234, 76, 148, 113, 10, 224, 187, 181, 157, 8, 166, 47, 26, 234 }, true },
                    { 5, new DateTime(2002, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1398), "quocndcde160171@fpt.edu.vn", "Quốc", "Quốc Nguyễn Đăng Cường", false, "0744532E6738DB9F3F56CE11DE164690D938E1F94BD2E464A33D9466C4A5883DA830779521A648D1CE707949FF9D1C007069070440CBB8491EC1ED2783E75E78", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", true, "Nguyễn Đăng Cường", new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(1399), 2, "0395459775", 1, new byte[] { 67, 197, 12, 171, 95, 16, 180, 218, 226, 114, 27, 174, 189, 182, 196, 106, 5, 145, 196, 59, 80, 232, 187, 88, 204, 123, 13, 118, 124, 244, 123, 139, 43, 194, 166, 156, 149, 228, 56, 7, 58, 67, 202, 74, 122, 17, 212, 174, 188, 20, 234, 76, 148, 113, 10, 224, 187, 181, 157, 8, 166, 47, 26, 234 }, false }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Đà Nẵng" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "LastUpdateDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6478), "Địa điểm công cộng", true },
                    { 2, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6489), "Bún đậu mắm tôm", true },
                    { 3, 4, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6492), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6493), "Karaoke", true },
                    { 4, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6496), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6496), "Nước mía", true },
                    { 5, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6499), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6499), "Bánh canh ruộng", true },
                    { 6, 4, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6504), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6504), "Bar", true },
                    { 7, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6507), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6507), "Rạp phim", true },
                    { 8, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6509), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6510), "Bảo tàng", true },
                    { 9, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6513), "Ốc", true },
                    { 10, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6517), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6525), "Gelato", true },
                    { 11, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6544), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6545), "Bingsu", true },
                    { 12, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6548), "Sinh tố", true },
                    { 13, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6551), "Chè", true },
                    { 14, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6554), "Súp", true },
                    { 15, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6557), "Trà sữa", true },
                    { 16, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6560), "Bida", true },
                    { 17, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6563), "Bún chả cá", true },
                    { 18, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6567), "Quán net", true },
                    { 19, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6570), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6571), "Ẩm thực Thái Lan", true },
                    { 20, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6573), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6574), "Bánh Huế", true },
                    { 21, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6577), "Spa", true },
                    { 22, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6579), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6580), "Kem bơ", true },
                    { 23, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6591), "Cơm gà", true },
                    { 24, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6593), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6594), "Pizza", true },
                    { 25, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6597), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6597), "Bánh tráng nướng", true },
                    { 26, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6600), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6600), "Thức uống detox", true },
                    { 27, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6604), "Đồ chay", true },
                    { 28, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6607), "Bún bò", true },
                    { 29, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6610), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6610), "Hải sản tươi sống", true },
                    { 30, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6613), "Nước ép trái cây", true },
                    { 31, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6615), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6616), "Chân gà nướng", true },
                    { 32, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6619), "Bánh xèo", true },
                    { 33, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6621), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6622), "Bánh ướt lòng gà", true },
                    { 34, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6625), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6626), "Bánh canh Nam Phổ", true },
                    { 35, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6629), "Cơm hến", true },
                    { 36, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6632), "Bún thái", true },
                    { 37, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6634), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6634), "Mì quảng", true },
                    { 38, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6637), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6637), "Cao lầu", true },
                    { 39, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6640), "Bánh cuốn", true },
                    { 40, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6643), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6643), "Bánh canh cua", true },
                    { 41, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6646), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6647), "Bánh mì chảo", true },
                    { 42, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6650), "Bún tôm Hải Phòng", true },
                    { 43, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6653), "Bún cá chấm", true },
                    { 44, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6663), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6664), "Bún chả Hà Nội", true },
                    { 45, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6666), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6667), "Bánh tôm Hồ Tây", true },
                    { 46, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6669), "Bánh đa cua", true },
                    { 47, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6673), "Phở", true },
                    { 48, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6675), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6675), "Xôi", true },
                    { 49, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6734), "Bún măng vịt", true },
                    { 50, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6737), "Cháo gà", true },
                    { 51, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6740), "Cháo vịt", true },
                    { 52, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6743), "Nước dừa", true },
                    { 53, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6745), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6745), "Bánh tráng trộn", true },
                    { 54, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6748), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6749), "Bánh tráng bơ", true },
                    { 55, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6751), "Lẩu cá", true },
                    { 56, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6754), "Cá đuối nướng", true },
                    { 57, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6757), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6757), "Thịt xiên nướng", true },
                    { 58, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6760), "Cá viên chiên", true },
                    { 59, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6762), "Freezer", true },
                    { 60, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6765), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6765), "Đồ uống nóng", true },
                    { 61, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6768), "Đồ ăn healthy", true },
                    { 62, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6771), "Bánh bò", true },
                    { 63, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6774), "Nem chua rán", true },
                    { 64, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6776), "Lẩu bò", true },
                    { 65, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6779), "Phá lấu", true },
                    { 66, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6792), "Trà chanh giã tay", true },
                    { 67, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6795), "Bún ốc", true },
                    { 68, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6798), "Bún riêu cua", true },
                    { 69, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6801), "Hủ tiếu", true },
                    { 70, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6803), "Sữa chua", true },
                    { 71, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6806), "Kem ký", true },
                    { 72, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6809), "Tàu hũ", true },
                    { 73, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6812), "Chuối nếp nướng", true },
                    { 74, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6814), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6814), "Cơm tấm", true },
                    { 75, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(6851), "Sữa đậu nành", true }
                });

            migrationBuilder.InsertData(
                table: "SubCategoryRequests",
                columns: new[] { "Id", "AccountId", "AdministratorId", "CategoryId", "CreateDate", "LastUpdateDate", "Name", "RequestUserId", "Status" },
                values: new object[,]
                {
                    { 1, null, 0, 2, new DateTime(2024, 3, 15, 12, 34, 25, 459, DateTimeKind.Local).AddTicks(7368), new DateTime(2024, 3, 15, 12, 34, 25, 459, DateTimeKind.Local).AddTicks(7374), "Súp cua", 1, 1 },
                    { 2, null, 0, 3, new DateTime(2024, 3, 15, 1, 44, 25, 459, DateTimeKind.Local).AddTicks(7397), new DateTime(2024, 3, 15, 1, 44, 25, 459, DateTimeKind.Local).AddTicks(7398), "Trà sữa pha máy", 3, 1 },
                    { 3, null, 0, 3, new DateTime(2024, 3, 15, 2, 44, 25, 459, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 3, 15, 2, 44, 25, 459, DateTimeKind.Local).AddTicks(7405), "Trà sữa ủ lạnh", 2, 1 },
                    { 4, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7411), "Bánh bèo", 2, 1 },
                    { 5, null, 0, 2, new DateTime(2024, 3, 15, 12, 39, 25, 459, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 3, 15, 12, 39, 25, 459, DateTimeKind.Local).AddTicks(7417), "Mì tôm hến", 4, 1 },
                    { 6, null, 0, 2, new DateTime(2024, 3, 15, 11, 54, 25, 459, DateTimeKind.Local).AddTicks(7422), new DateTime(2024, 3, 15, 11, 54, 25, 459, DateTimeKind.Local).AddTicks(7423), "Phở vịt quay", 3, 1 },
                    { 7, null, 0, 2, new DateTime(2024, 3, 15, 12, 4, 25, 459, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 3, 15, 12, 4, 25, 459, DateTimeKind.Local).AddTicks(7429), "Phở khô Gia Lai", 1, 1 },
                    { 8, null, 0, 2, new DateTime(2024, 3, 15, 11, 44, 25, 459, DateTimeKind.Local).AddTicks(7434), new DateTime(2024, 3, 15, 11, 44, 25, 459, DateTimeKind.Local).AddTicks(7435), "Cơm âm phủ", 3, 1 },
                    { 9, null, 0, 2, new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7441), "Bún thịt nướng", 4, 1 },
                    { 10, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7448), "Bánh nậm", 2, 1 },
                    { 11, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7454), "Bánh ít trần", 4, 1 },
                    { 12, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7459), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7459), "Bánh bột lọc lá", 4, 1 },
                    { 13, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7465), "Bánh bột lọc trần", 3, 1 },
                    { 14, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7480), "Bánh canh Nam Phổ", 2, 1 },
                    { 15, null, 0, 2, new DateTime(2024, 3, 15, 6, 44, 25, 459, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 3, 15, 6, 44, 25, 459, DateTimeKind.Local).AddTicks(7486), "Chân gà xào cay", 1, 1 },
                    { 16, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7494), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7495), "Bánh cuốn chả mực", 2, 1 },
                    { 17, null, 0, 2, new DateTime(2024, 3, 15, 12, 14, 25, 459, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 3, 15, 12, 14, 25, 459, DateTimeKind.Local).AddTicks(7501), "Bò né", 3, 1 },
                    { 18, null, 0, 2, new DateTime(2024, 3, 15, 12, 19, 25, 459, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 3, 15, 12, 19, 25, 459, DateTimeKind.Local).AddTicks(7507), "Phở bê thui", 3, 1 },
                    { 19, null, 0, 2, new DateTime(2024, 3, 15, 10, 44, 25, 459, DateTimeKind.Local).AddTicks(7512), new DateTime(2024, 3, 15, 10, 44, 25, 459, DateTimeKind.Local).AddTicks(7513), "Phở gà", 1, 1 },
                    { 20, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7517), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7518), "Bánh mì cá hồi", 2, 1 },
                    { 21, null, 0, 2, new DateTime(2024, 3, 15, 7, 44, 25, 459, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 3, 15, 7, 44, 25, 459, DateTimeKind.Local).AddTicks(7524), "Xôi cade", 3, 1 },
                    { 22, null, 0, 2, new DateTime(2024, 3, 15, 5, 44, 25, 459, DateTimeKind.Local).AddTicks(7528), new DateTime(2024, 3, 15, 5, 44, 25, 459, DateTimeKind.Local).AddTicks(7529), "Há cảo", 2, 1 },
                    { 23, null, 0, 2, new DateTime(2024, 3, 15, 2, 44, 25, 459, DateTimeKind.Local).AddTicks(7533), new DateTime(2024, 3, 15, 2, 44, 25, 459, DateTimeKind.Local).AddTicks(7534), "Chân gà tàu xì", 1, 1 },
                    { 24, null, 0, 2, new DateTime(2024, 3, 15, 1, 44, 25, 459, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 3, 15, 1, 44, 25, 459, DateTimeKind.Local).AddTicks(7539), "Bún ốc Tiều Châu", 2, 1 },
                    { 25, null, 0, 2, new DateTime(2024, 3, 13, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7551), new DateTime(2024, 3, 13, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7552), "Súp xương chả", 1, 1 },
                    { 26, null, 0, 2, new DateTime(2024, 3, 15, 8, 44, 25, 459, DateTimeKind.Local).AddTicks(7557), new DateTime(2024, 3, 15, 8, 44, 25, 459, DateTimeKind.Local).AddTicks(7558), "Cháo tôm hùm", 2, 1 },
                    { 27, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7620), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7621), "Súp bào ngư", 2, 1 },
                    { 28, null, 0, 2, new DateTime(2024, 3, 15, 12, 29, 25, 459, DateTimeKind.Local).AddTicks(7626), new DateTime(2024, 3, 15, 12, 29, 25, 459, DateTimeKind.Local).AddTicks(7627), "Phở tôm hùm", 4, 1 },
                    { 29, null, 0, 2, new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7633), "Cá viên chiên nước mắm", 1, 1 },
                    { 30, null, 0, 2, new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7639), new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7640), "Cá viên chiên sốt trứng muối", 1, 1 },
                    { 31, null, 0, 3, new DateTime(2024, 3, 15, 12, 39, 25, 459, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 3, 15, 12, 39, 25, 459, DateTimeKind.Local).AddTicks(7646), "Chè bánh lọt", 4, 1 },
                    { 32, null, 0, 2, new DateTime(2024, 3, 15, 12, 34, 25, 459, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 3, 15, 12, 34, 25, 459, DateTimeKind.Local).AddTicks(7652), "Bánh chuối", 4, 1 },
                    { 33, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7658), "Chè ba màu", 1, 1 },
                    { 34, null, 0, 2, new DateTime(2024, 3, 15, 8, 44, 25, 459, DateTimeKind.Local).AddTicks(7663), new DateTime(2024, 3, 15, 8, 44, 25, 459, DateTimeKind.Local).AddTicks(7664), "Chè thưng", 3, 1 },
                    { 35, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7669), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7670), "Nem chua nướng", 4, 1 },
                    { 36, null, 0, 2, new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7681), new DateTime(2024, 3, 15, 9, 44, 25, 459, DateTimeKind.Local).AddTicks(7681), "Bún chẻo", 3, 1 },
                    { 37, null, 0, 2, new DateTime(2024, 3, 15, 5, 44, 25, 459, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 3, 15, 5, 44, 25, 459, DateTimeKind.Local).AddTicks(7687), "Bún cua thối", 3, 1 },
                    { 38, null, 0, 2, new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7692), new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7693), "Hủ tiếu Tiều Châu", 4, 1 },
                    { 39, null, 0, 3, new DateTime(2024, 3, 11, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7697), new DateTime(2024, 3, 11, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7698), "Trà chanh giã tay", 1, 1 },
                    { 40, null, 0, 2, new DateTime(2024, 3, 15, 12, 41, 25, 459, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 3, 15, 12, 41, 25, 459, DateTimeKind.Local).AddTicks(7704), "Hủ tiếu Nam Vang", 4, 1 },
                    { 41, null, 0, 2, new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7708), new DateTime(2024, 3, 14, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(7709), "Hủ tiếu gõ", 2, 1 },
                    { 42, null, 0, 2, new DateTime(2024, 3, 15, 12, 24, 25, 459, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 3, 15, 12, 24, 25, 459, DateTimeKind.Local).AddTicks(7715), "Tàu hũ xe lam", 1, 1 },
                    { 43, null, 0, 2, new DateTime(2024, 3, 15, 11, 59, 25, 459, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 3, 15, 11, 59, 25, 459, DateTimeKind.Local).AddTicks(7720), "Chè khoai tía", 3, 1 },
                    { 44, null, 0, 2, new DateTime(2024, 3, 15, 11, 59, 25, 459, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 3, 15, 11, 59, 25, 459, DateTimeKind.Local).AddTicks(7725), "Chè mè đen", 1, 1 },
                    { 45, null, 0, 3, new DateTime(2024, 3, 15, 11, 54, 25, 459, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 3, 15, 11, 54, 25, 459, DateTimeKind.Local).AddTicks(7731), "Expresso", 4, 1 },
                    { 46, null, 0, 3, new DateTime(2024, 3, 15, 10, 44, 25, 459, DateTimeKind.Local).AddTicks(7735), new DateTime(2024, 3, 15, 10, 44, 25, 459, DateTimeKind.Local).AddTicks(7736), "Cappuccino", 2, 1 },
                    { 47, null, 0, 4, new DateTime(2024, 3, 15, 7, 44, 25, 459, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 3, 15, 7, 44, 25, 459, DateTimeKind.Local).AddTicks(7748), "Cà phê acoustic", 1, 1 },
                    { 48, null, 0, 2, new DateTime(2024, 3, 15, 8, 44, 25, 459, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 3, 15, 8, 44, 25, 459, DateTimeKind.Local).AddTicks(7753), "Ẩm thực Tây Bắc", 4, 1 },
                    { 49, null, 0, 2, new DateTime(2024, 3, 15, 4, 44, 25, 459, DateTimeKind.Local).AddTicks(7758), new DateTime(2024, 3, 15, 4, 44, 25, 459, DateTimeKind.Local).AddTicks(7759), "Cháo quẩy", 2, 1 },
                    { 50, null, 0, 2, new DateTime(2024, 3, 15, 12, 39, 25, 459, DateTimeKind.Local).AddTicks(7793), new DateTime(2024, 3, 15, 12, 39, 25, 459, DateTimeKind.Local).AddTicks(7794), "Sushi", 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Hải Châu" },
                    { 2, 1, "Cẩm Lệ" },
                    { 3, 1, "Liên Chiểu" },
                    { 4, 1, "Thanh Khê" },
                    { 5, 1, "Sơn Trà" },
                    { 6, 1, "Ngũ Hành Sơn" }
                });

            migrationBuilder.InsertData(
                table: "Wards",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bình Hiên" },
                    { 2, 1, "Bình Thuận" },
                    { 3, 1, "Hải Châu 1" },
                    { 4, 1, "Hải Châu 2" },
                    { 5, 1, "Hòa Cường Bắc" },
                    { 6, 1, "Hòa Cường Nam" },
                    { 7, 1, "Hòa Thuận Đông" },
                    { 8, 1, "Hòa Thuận Tây" },
                    { 9, 1, "Nam Dương" },
                    { 10, 1, "Phước Ninh" },
                    { 11, 1, "Thạch Thang" },
                    { 12, 1, "Thanh Bình" },
                    { 13, 1, "Thuận Phước" },
                    { 14, 2, "Hòa An" },
                    { 15, 2, "Hòa Phát" },
                    { 16, 2, "Hòa Thọ Đông" },
                    { 17, 2, "Hòa Thọ Tây" },
                    { 18, 2, "Hòa Xuân" },
                    { 19, 2, "Khuê Trung" },
                    { 20, 3, "Hòa Hiệp Bắc" },
                    { 21, 3, "Hòa Hiệp Nam" },
                    { 22, 3, "Hòa Khánh Bắc" },
                    { 23, 3, "Hòa Khánh Nam" },
                    { 24, 3, "Hòa Minh" },
                    { 25, 4, "An Khê" },
                    { 26, 4, "Hòa Khê" },
                    { 27, 4, "Thanh Khê Đông" },
                    { 28, 4, "Thanh Khê Tây" },
                    { 29, 4, "Xuân Hà" },
                    { 30, 4, "Tam Thuận" },
                    { 31, 4, "Tân Chính" },
                    { 32, 4, "Chính Gián" },
                    { 33, 4, "Thạc Gián" },
                    { 34, 4, "Vĩnh Trung" },
                    { 35, 5, "An Hải Bắc" },
                    { 36, 5, "An Hải Đông" },
                    { 37, 5, "An Hải Tây" },
                    { 38, 5, "Mân Thái" },
                    { 39, 5, "Nại Hiên Đông" },
                    { 40, 5, "Phước Mỹ" },
                    { 41, 5, "Thọ Quang" },
                    { 42, 6, "Hòa Hải" },
                    { 43, 6, "Hòa Quý" },
                    { 44, 6, "Khuê Mỹ" },
                    { 45, 6, "Mỹ An" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "AccountId", "CloseTime", "Description", "GeoLocation", "Image", "LowerPrice", "Name", "OpenTime", "Status", "Street", "UpperPrice", "WardId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Đỉnh Bàn Cờ", "16.1203775657414,108.27607464602765", "https://lh5.googleusercontent.com/p/AF1QipNTJk8DvgrCr2RyeTfKzedNpx4o4LOO06rSXSVQ=w408-h272-k-no", 0f, "Đỉnh Bàn Cờ", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 0f, 41 },
                    { 2, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Rồng", "16.061233815354754,108.22749003748194", "https://static.vinwonders.com/2022/04/cau-rong-da-nang-1-1.jpg", 0f, "Cầu Rồng", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Văn Linh", 0f, 10 },
                    { 3, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Sông Hàn", "16.072169332052994,108.22683626631773", "https://lh5.googleusercontent.com/p/AF1QipPR0yFg71ydHaR3xXbbMApGnySOSmF5IBCXeWmc=w408-h306-k-no", 0f, "Cầu Sông Hàn", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lê Duẩn", 0f, 3 },
                    { 4, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Nguyễn Văn Trỗi", "16.05112083078253,108.22907016535224", "https://lh5.googleusercontent.com/p/AF1QipNTJk8DvgrCr2RyeTfKzedNpx4o4LOO06rSXSVQ=w408-h272-k-no", 0f, "Cầu Nguyễn Văn Trỗi", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Văn Thoại", 0f, 37 },
                    { 5, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Tình Yêu", "16.1203775657414,108.27607464602765", "https://ik.imagekit.io/tvlk/blog/2023/08/cau-tinh-yeu-da-nang-2.jpg?tr=dpr-2", 0f, "Cầu Tình Yêu", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Trần Hưng Đạo", 0f, 37 },
                    { 6, 1, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Chợ đêm Sơn Trà", "16.06160809465977,108.23198549515325", "https://lh5.googleusercontent.com/p/AF1QipOy3zJV9uGKBOAvqq7JfD47k-pJ3pJdX08AsFqt=w493-h240-k-no", 0f, "Chợ đêm Sơn Trà", new DateTime(2024, 3, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "Mai Hắc Đế", 0f, 37 },
                    { 7, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Tượng Cá Chép hóa Rồng", "16.062920294590672,108.22982572398891", "https://lh3.googleusercontent.com/p/AF1QipOsja5mY4FutBBksUpPGk7xtTfT2LONbebEZsIY=s1360-w1360-h1020", 0f, "Tượng Cá Chép hóa Rồng", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Trần Hưng Đạo", 0f, 37 },
                    { 8, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Biển Mỹ Khê", "16.05658360521848,108.24744872398874", "https://lh5.googleusercontent.com/p/AF1QipPgpkvaWeKD9pejm2Org-oEx-SWXLyGH_qSUneu=w426-h240-k-no", 0f, "Biển Mỹ Khê", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Võ Nguyên Giáp", 0f, 42 },
                    { 9, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Công viên 29/3", "16.1203775657414,108.27607464602765", "https://lh5.googleusercontent.com/p/AF1QipNPIejeI79llYfMNFnAdGnaBKNCt6G4Fwo6Q2tM=w426-h240-k-no", 0f, "Công viên 29/3", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "23 Nguyễn Tri Phương", 0f, 33 },
                    { 10, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Bãi tắm Phạm Văn Đồng", "16.07338349250206,108.24686918822724", "https://lh5.googleusercontent.com/p/AF1QipMeJRsg8S_9w2m3KaBuovV_87uF5IsM8eubr1vY=w408-h272-k-no", 0f, "Bãi tắm Phạm Văn Đồng", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Võ Nguyên Giáp", 0f, 37 },
                    { 11, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Bãi đá Obama", "16.09979446980971,108.30122137705182", "https://lh5.googleusercontent.com/p/AF1QipNZY0gLKkyBp6SeM7KEMPadCos2lOCHNwWhAIvI=w408-h354-k-no", 0f, "Bãi đá Obama", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 0f, 41 },
                    { 12, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Chân cầu Thuận Phước.", "16.095265292762104,108.22045666551136", "https://lh5.googleusercontent.com/p/AF1QipP4U2h2NuO5IC4xNdkPtRO0hTpg-kRLkUo1RuYY=w408-h271-k-no", 0f, "Chân cầu Thuận Phước.", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lê Đức Thọ", 0f, 39 },
                    { 13, 1, new DateTime(2024, 3, 15, 22, 30, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Chợ đêm Helio", "16.037429266613337,108.22457798825782", "https://lh5.googleusercontent.com/p/AF1QipOT5qP5cG4MJAC6pFlFwbNhpTJRFBKDZi16uD79=w408-h306-k-no", 0f, "Chợ đêm Helio", new DateTime(2024, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "2 Tháng 9", 0f, 5 },
                    { 14, 1, new DateTime(2024, 3, 15, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Rạn Nam Ô", "16.117981036882956,108.13000619993463", "https://lh5.googleusercontent.com/p/AF1QipPLWohOtxqRtG8sPz8yFNmPk7UA_QovxpBtwifr=w408-h305-k-no", 0f, "Rạn Nam Ô", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 0f, 21 }
                });

            migrationBuilder.InsertData(
                table: "VenueSubCategories",
                columns: new[] { "SubCategoryId", "VenueId", "CreateDate", "LastUpdateDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9438), true },
                    { 1, 2, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9454), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9454), true },
                    { 1, 3, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9460), true },
                    { 1, 4, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9467), true },
                    { 1, 5, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9473), true },
                    { 1, 6, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9496), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9496), true },
                    { 1, 7, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9503), true },
                    { 1, 8, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9508), true },
                    { 1, 9, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9514), true },
                    { 1, 10, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9563), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9564), true },
                    { 1, 11, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9577), true },
                    { 1, 12, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9583), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9583), true },
                    { 1, 13, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9589), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9589), true },
                    { 1, 14, new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 3, 15, 12, 44, 25, 459, DateTimeKind.Local).AddTicks(9595), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryRequests_AccountId",
                table: "SubCategoryRequests",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryRequests_CategoryId",
                table: "SubCategoryRequests",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_AccountId",
                table: "Venues",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_WardId",
                table: "Venues",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueSubCategories_SubCategoryId",
                table: "VenueSubCategories",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VNPAYPayments_UserId",
                table: "VNPAYPayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_DistrictId",
                table: "Wards",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategoryRequests");

            migrationBuilder.DropTable(
                name: "VenueSubCategories");

            migrationBuilder.DropTable(
                name: "VNPAYPayments");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
