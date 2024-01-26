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
                    CategoryId = table.Column<int>(type: "int", nullable: false)
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
                    LoginVia = table.Column<int>(type: "int", nullable: false),
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
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "BirthDay", "CreateDate", "Email", "FirstName", "FullName", "Gender", "HashPassword", "Image", "IsEmailConfirmed", "LastName", "LastUpdateDate", "LoginVia", "PhoneNumber", "RoleId", "SaltPassword", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(8915), "huynhduy20042002@gmail.com", "Duy", "Duy Lê Tự Huỳnh", true, "104847E09FB98DAFCAF13047CB0F6C1CE2B1E0D18605B7B2EB4DF9013D507EA92694D361038FD79F8AD0F9060713C991DAEE799332A5D597292E68076FB97F69", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Lê Tự Huỳnh", new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(8933), 1, "0288639633", 1, new byte[] { 59, 174, 56, 180, 150, 223, 181, 203, 78, 208, 175, 240, 10, 123, 165, 35, 146, 136, 184, 32, 115, 213, 246, 232, 238, 182, 173, 32, 111, 161, 227, 76, 73, 37, 86, 13, 108, 12, 144, 43, 124, 31, 2, 108, 71, 40, 183, 51, 41, 79, 62, 65, 3, 41, 247, 191, 190, 217, 154, 22, 174, 243, 168, 58 }, true },
                    { 2, new DateTime(2002, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9029), "phuchvde160270@fpt.edu.vn", "Phúc", "Phúc Hồ Văn", true, "104847E09FB98DAFCAF13047CB0F6C1CE2B1E0D18605B7B2EB4DF9013D507EA92694D361038FD79F8AD0F9060713C991DAEE799332A5D597292E68076FB97F69", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Hồ Văn", new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9029), 1, "0254719274", 1, new byte[] { 59, 174, 56, 180, 150, 223, 181, 203, 78, 208, 175, 240, 10, 123, 165, 35, 146, 136, 184, 32, 115, 213, 246, 232, 238, 182, 173, 32, 111, 161, 227, 76, 73, 37, 86, 13, 108, 12, 144, 43, 124, 31, 2, 108, 71, 40, 183, 51, 41, 79, 62, 65, 3, 41, 247, 191, 190, 217, 154, 22, 174, 243, 168, 58 }, true },
                    { 3, new DateTime(2000, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9048), "hungnhde160214@fpt.edu.vn", "Hùng", "Hùng Nguyễn Huy", true, "104847E09FB98DAFCAF13047CB0F6C1CE2B1E0D18605B7B2EB4DF9013D507EA92694D361038FD79F8AD0F9060713C991DAEE799332A5D597292E68076FB97F69", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Nguyễn Huy", new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9049), 1, "0264944874", 1, new byte[] { 59, 174, 56, 180, 150, 223, 181, 203, 78, 208, 175, 240, 10, 123, 165, 35, 146, 136, 184, 32, 115, 213, 246, 232, 238, 182, 173, 32, 111, 161, 227, 76, 73, 37, 86, 13, 108, 12, 144, 43, 124, 31, 2, 108, 71, 40, 183, 51, 41, 79, 62, 65, 3, 41, 247, 191, 190, 217, 154, 22, 174, 243, 168, 58 }, true },
                    { 4, new DateTime(2002, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9113), "trilmde160230@fpt.edu.vn", "Trí", "Trí Lê Minh", true, "104847E09FB98DAFCAF13047CB0F6C1CE2B1E0D18605B7B2EB4DF9013D507EA92694D361038FD79F8AD0F9060713C991DAEE799332A5D597292E68076FB97F69", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Lê Minh", new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9114), 1, "0955674783", 1, new byte[] { 59, 174, 56, 180, 150, 223, 181, 203, 78, 208, 175, 240, 10, 123, 165, 35, 146, 136, 184, 32, 115, 213, 246, 232, 238, 182, 173, 32, 111, 161, 227, 76, 73, 37, 86, 13, 108, 12, 144, 43, 124, 31, 2, 108, 71, 40, 183, 51, 41, 79, 62, 65, 3, 41, 247, 191, 190, 217, 154, 22, 174, 243, 168, 58 }, true },
                    { 5, new DateTime(2002, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9130), "quocndcde160171@fpt.edu.vn", "Quốc", "Quốc Nguyễn Đăng Cường", true, "104847E09FB98DAFCAF13047CB0F6C1CE2B1E0D18605B7B2EB4DF9013D507EA92694D361038FD79F8AD0F9060713C991DAEE799332A5D597292E68076FB97F69", "D:\\Visual Studio 2022\\C#\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg", false, "Nguyễn Đăng Cường", new DateTime(2024, 1, 26, 14, 45, 33, 582, DateTimeKind.Local).AddTicks(9131), 1, "0828459612", 1, new byte[] { 59, 174, 56, 180, 150, 223, 181, 203, 78, 208, 175, 240, 10, 123, 165, 35, 146, 136, 184, 32, 115, 213, 246, 232, 238, 182, 173, 32, 111, 161, 227, 76, 73, 37, 86, 13, 108, 12, 144, 43, 124, 31, 2, 108, 71, 40, 183, 51, 41, 79, 62, 65, 3, 41, 247, 191, 190, 217, 154, 22, 174, 243, 168, 58 }, true }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Đà Nẵng" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 1, 1, "Địa điểm công cộng" });

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
                    { 5, 1, "Hoà Cường Bắc" },
                    { 6, 1, "Hoà Cường Nam" },
                    { 7, 1, "Hoà Thuận Đông" },
                    { 8, 1, "Hoà Thuận Tây" },
                    { 9, 1, "Nam Dương" },
                    { 10, 1, "Phước Ninh" },
                    { 11, 1, "Thạch Thang" },
                    { 12, 1, "Thanh Bình" },
                    { 13, 1, "Thuận Phước" },
                    { 14, 2, "Hoà An" },
                    { 15, 2, "Hoà Phát" },
                    { 16, 2, "Hoà Thọ Đông" },
                    { 17, 2, "Hoà Thọ Tây" },
                    { 18, 2, "Hoà Xuân" },
                    { 19, 2, "Khuê Trung" },
                    { 20, 3, "Hoà Hiệp Bắc" },
                    { 21, 3, "Hoà Hiệp Nam" },
                    { 22, 3, "Hoà Khánh Bắc" },
                    { 23, 3, "Hoà Khánh Nam" },
                    { 24, 3, "Hoà Minh" },
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
                    { 42, 6, "Hoà Hải" },
                    { 43, 6, "Hoà Quý" },
                    { 44, 6, "Khuê Mỹ" },
                    { 45, 6, "Mỹ An" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "AccountId", "CloseTime", "Description", "GeoLocation", "Image", "LowerPrice", "Name", "OpenTime", "Status", "Street", "UpperPrice", "WardId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Đỉnh Bàn Cờ", "16.1203775657414,108.27607464602765", "https://lh5.googleusercontent.com/p/AF1QipNTJk8DvgrCr2RyeTfKzedNpx4o4LOO06rSXSVQ=w408-h272-k-no", 0f, "Đỉnh Bàn Cờ", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 0f, 41 },
                    { 2, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Rồng", "16.061233815354754,108.22749003748194", "https://static.vinwonders.com/2022/04/cau-rong-da-nang-1-1.jpg", 0f, "Cầu Rồng", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Văn Linh", 0f, 10 },
                    { 3, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Sông Hàn", "16.072169332052994,108.22683626631773", "https://lh5.googleusercontent.com/p/AF1QipPR0yFg71ydHaR3xXbbMApGnySOSmF5IBCXeWmc=w408-h306-k-no", 0f, "Cầu Sông Hàn", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lê Duẩn", 0f, 3 },
                    { 4, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Nguyễn Văn Trỗi", "16.05112083078253,108.22907016535224", "https://lh5.googleusercontent.com/p/AF1QipNTJk8DvgrCr2RyeTfKzedNpx4o4LOO06rSXSVQ=w408-h272-k-no", 0f, "Cầu Nguyễn Văn Trỗi", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Văn Thoại", 0f, 37 },
                    { 5, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Cầu Tình Yêu", "16.1203775657414,108.27607464602765", "https://ik.imagekit.io/tvlk/blog/2023/08/cau-tinh-yeu-da-nang-2.jpg?tr=dpr-2", 0f, "Cầu Tình Yêu", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Trần Hưng Đạo", 0f, 37 },
                    { 6, 1, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Chợ đêm Sơn Trà", "16.06160809465977,108.23198549515325", "https://lh5.googleusercontent.com/p/AF1QipOy3zJV9uGKBOAvqq7JfD47k-pJ3pJdX08AsFqt=w493-h240-k-no", 0f, "Chợ đêm Sơn Trà", new DateTime(2024, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "Mai Hắc Đế", 0f, 37 },
                    { 7, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Tượng Cá Chép hóa Rồng", "16.062920294590672,108.22982572398891", "https://lh3.googleusercontent.com/p/AF1QipOsja5mY4FutBBksUpPGk7xtTfT2LONbebEZsIY=s1360-w1360-h1020", 0f, "Tượng Cá Chép hóa Rồng", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Trần Hưng Đạo", 0f, 37 },
                    { 8, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Biển Mỹ Khê", "16.05658360521848,108.24744872398874", "https://lh5.googleusercontent.com/p/AF1QipPgpkvaWeKD9pejm2Org-oEx-SWXLyGH_qSUneu=w426-h240-k-no", 0f, "Biển Mỹ Khê", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Võ Nguyên Giáp", 0f, 42 },
                    { 9, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Công viên 29/3", "16.1203775657414,108.27607464602765", "https://lh5.googleusercontent.com/p/AF1QipNPIejeI79llYfMNFnAdGnaBKNCt6G4Fwo6Q2tM=w426-h240-k-no", 0f, "Công viên 29/3", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "23 Nguyễn Tri Phương", 0f, 33 },
                    { 10, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Bãi tắm Phạm Văn Đồng", "16.07338349250206,108.24686918822724", "https://lh5.googleusercontent.com/p/AF1QipMeJRsg8S_9w2m3KaBuovV_87uF5IsM8eubr1vY=w408-h272-k-no", 0f, "Bãi tắm Phạm Văn Đồng", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Võ Nguyên Giáp", 0f, 37 },
                    { 11, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Bãi đá Obama", "16.09979446980971,108.30122137705182", "https://lh5.googleusercontent.com/p/AF1QipNZY0gLKkyBp6SeM7KEMPadCos2lOCHNwWhAIvI=w408-h354-k-no", 0f, "Bãi đá Obama", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 0f, 41 },
                    { 12, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Chân cầu Thuận Phước.", "16.095265292762104,108.22045666551136", "https://lh5.googleusercontent.com/p/AF1QipP4U2h2NuO5IC4xNdkPtRO0hTpg-kRLkUo1RuYY=w408-h271-k-no", 0f, "Chân cầu Thuận Phước.", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Lê Đức Thọ", 0f, 39 },
                    { 13, 1, new DateTime(2024, 1, 26, 22, 30, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Chợ đêm Helio", "16.037429266613337,108.22457798825782", "https://lh5.googleusercontent.com/p/AF1QipOT5qP5cG4MJAC6pFlFwbNhpTJRFBKDZi16uD79=w408-h306-k-no", 0f, "Chợ đêm Helio", new DateTime(2024, 1, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "2 Tháng 9", 0f, 5 },
                    { 14, 1, new DateTime(2024, 1, 26, 23, 59, 0, 0, DateTimeKind.Unspecified), "Đây là mô tả về Rạn Nam Ô", "16.117981036882956,108.13000619993463", "https://lh5.googleusercontent.com/p/AF1QipPLWohOtxqRtG8sPz8yFNmPk7UA_QovxpBtwifr=w408-h305-k-no", 0f, "Rạn Nam Ô", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 0f, 21 }
                });

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
                name: "IX_Wards_DistrictId",
                table: "Wards",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VenueSubCategories");

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
