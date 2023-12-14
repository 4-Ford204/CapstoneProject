using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class FVenue_V1_SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Roles_RoleId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueManager_Roles_RoleId",
                table: "VenueManager");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueManager_Venues_VenueId",
                table: "VenueManager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VenueManager",
                table: "VenueManager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "VenueManager",
                newName: "VenueManagers");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_VenueManager_VenueId",
                table: "VenueManagers",
                newName: "IX_VenueManagers_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_VenueManager_RoleId",
                table: "VenueManagers",
                newName: "IX_VenueManagers_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_User_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.AddColumn<string>(
                name: "SaltPassword",
                table: "VenueManagers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaltPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VenueManagers",
                table: "VenueManagers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Việt Nam" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Đà Nẵng" });

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
                columns: new[] { "Id", "CloseTime", "GeoLocation", "Image", "LowerPrice", "Name", "OpenTime", "Status", "Street", "UpperPrice", "WardId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.06455997394997,108.22441916780322", "https://lh3.googleusercontent.com/p/AF1QipMm8Z4o8Fb7MjSkSxRNFs65YxDPhEOSL8OfU1o1=s1360-w1360-h1020", 30f, "Reply 1988 Cafe", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "20 Lê Hồng Phong", 49f, 10 },
                    { 2, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.067049562217697,108.22367868214609", "https://dw82ptradz9jo.cloudfront.net/daylog/6319f8b27597e2539ed6481d/755c281a-7b27-4e95-be1c-1f0c000f42c2", 35f, "Boulevard Gelato & Coffee", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "77 Trần Quốc Toản", 65f, 10 },
                    { 3, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.069789196796957,108.22523309107305", "https://lh3.googleusercontent.com/p/AF1QipPMUVsOGYKBOSYDkF-I7V7ky0PW2hq1SQih8vsC=w768-h768-n-o-v1", 35f, "WONDERLUST Bakery & Coffee", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "96 Trần Phú", 155f, 3 },
                    { 4, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.07962272110566,108.22717654302866", "https://media.mia.vn/uploads/blog-du-lich/96-Coffee-and-Apartment-Quan-cafe-voi-khong-gian-cuc-chat-bat-tron-con-tim-gioi-tre-11-1636927232.jpg", 28f, "96 Coffee & Apartment", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "28 Bạch Đằng", 38f, 11 },
                    { 5, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.05704072643852,108.22436636780321", "https://media.mia.vn/uploads/blog-du-lich/Cafe-de-Ante-Quan-cafe-mang-dam-chat-vintage-day-lang-man-tai-Da-Nang-05-1637013714.jpg", 25f, "Ante Café", new DateTime(2023, 12, 11, 7, 30, 0, 0, DateTimeKind.Unspecified), true, "43 Trần Văn Trứ", 50f, 2 },
                    { 6, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.067167444338654,108.22330615181086", "https://danalocal.info/wp-content/uploads/2023/10/check-in-quan-ca-phe-phong-cach-nhat-ban-voi-khoang-san-vuon-rong-rai-2-1.jpg", 25f, "HICHI Coffee", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "56 Trần Quốc Toản", 55f, 3 },
                    { 7, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.073313650548595,108.22335093711116", "https://cdn.vn.alongwalk.info/wp-content/uploads/2022/12/31181333/image-goc-nha-tui-minh-nham-nhi-tach-tra-hoai-niem-c7346a30206043852d5a7d46491f60d4.jpg", 15f, "Trà Quán-Góc Nhà Tụi Mình", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "36/36 Lê Duẩn", 60f, 3 },
                    { 8, new DateTime(2023, 12, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "16.069849295973697,108.22418666088257", "https://scontent.fhan2-3.fna.fbcdn.net/v/t1.6435-9/107259580_10157712282849005_362475914545938565_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=7f8c78&_nc_ohc=04xUzuKLDo0AX9wMZOV&_nc_ht=scontent.fhan2-3.fna&oh=00_AfCzXSqdGDWUeTql6eBJM0mp6XVmcxB_FVwH2_-4aItK6A&oe=659680D0", 29f, "Cộng Cà phê", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "39-41 Nguyễn Thái Học", 69f, 3 },
                    { 9, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.070848223645793,108.22682929057149", "https://d3tosvr3yotk6r.cloudfront.net/Content/UserUploads/Images/Locations/4/13/medium_Highlands%20Coffee%202.jpeg", 29f, "Highlands Coffee", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "74 Bạch Đằng", 69f, 3 },
                    { 10, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.072521502062475,108.21730632326984", "https://media.mia.vn/uploads/blog-du-lich/The-59-Cafe-Quan-cafe-nup-hem-voi-ve-dep-hoai-co-dac-biet-12-1637006703.jpg", 27f, "The 59 Café", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "K59 Hải Phòng", 45f, 11 },
                    { 11, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.076285050379397,108.21567723069205", "https://gotadi.com/tour/wp-content/uploads/2021/10/22-quan-cafe-checkin-dep-o-da-nang.jpg.jpg", 25f, "Fil’s Cafe", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "225/3 Đống Đa", 45f, 11 },
                    { 12, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.056527828829243,108.22443508214609", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/337854213_757650695946874_6606077903618022803_n.jpg?stp=cp6_dst-jpg&_nc_cat=101&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=JUcXk7NCsTcAX9XyzKJ&_nc_ht=scontent.fhan2-3.fna&oh=00_AfDIXL61lioInKZDXg7hOybGBQrttOSgqAuYey6vawayNg&oe=6573D5A8", 20f, "Đốm Café", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "22 Lê Quý Đôn", 55f, 2 },
                    { 13, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.06334291750872,108.22548942868579", "https://www.willflyforfood.net/wp-content/uploads/2023/04/da-nang-cafes-ca-phe-muoi-hue3.jpg.webp", 25f, "Cà phê muối Huế-N Cafe", new DateTime(2023, 12, 11, 6, 30, 0, 0, DateTimeKind.Unspecified), true, "254 Trần Phú", 45f, 10 },
                    { 14, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.06580364347106,108.22456163510483", "https://media.mia.vn/uploads/blog-du-lich/grand-t-coffee-da-nang-diem-check-in-co-mot-khong-hai-o-thanh-pho-bien-06-1637383291.jpg", 18f, "Grand T Coffee", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "287 Nguyễn Chí Thanh", 45f, 10 },
                    { 15, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.064213492997045,108.22374563711114", "https://media.mia.vn/uploads/blog-du-lich/ghe-tham-nam-house-coffee-ngoi-nha-co-kinh-giua-long-da-nang-05-1636472384.jpg", 18f, "Nam House", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "15/1 Lê Hồng Phong", 35f, 10 },
                    { 16, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.07460320690479,108.22346257522545", "https://d3tosvr3yotk6r.cloudfront.net/Content/UserUploads/Images/Locations/4/1290/medium_26166460_1772629336143740_8907434179439755635_nnnnnnnn.jpg", 15f, "Nối Café", new DateTime(2023, 12, 11, 6, 30, 0, 0, DateTimeKind.Unspecified), true, "113/18 Nguyễn Chí Thanh", 35f, 3 },
                    { 17, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.07256542587245,108.21632549006992", "https://media.mia.vn/uploads/blog-du-lich/tro-ve-thoi-ong-ba-anh-cung-tiem-nuoc-bao-cap-2-1636209527.jpg", 15f, "Tiệm nước Bao Cấp", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "176 Hải Phòng", 35f, 11 },
                    { 18, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.04994070960559,108.20803067051723", "https://www.cotrang.org/tin-tuc/images/quan-cafe/da-nang/trinh-cafe/trinh-cafe-da-nang-nguyen-huu-tho-ttgt-03.jpg", 22f, "Trình Cà Phê", new DateTime(2023, 12, 11, 6, 30, 0, 0, DateTimeKind.Unspecified), true, "34/4 Nguyễn Hữu Thọ", 42f, 8 },
                    { 19, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.047644350639974,108.22777787", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/344131229_801472484644331_1427410694409761171_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=783fdb&_nc_ohc=oykt8sfCuZUAX8JCbAq&_nc_ht=scontent.fhan2-3.fna&oh=00_AfCpKmCUT6itqW7e0bdLc96uskQhsHgB_gR5bptU7f8M3g&oe=657353B1", 29f, "H-Amazon Coffee", new DateTime(2023, 12, 11, 6, 30, 0, 0, DateTimeKind.Unspecified), true, "5 Đảo Xanh 1", 55f, 5 },
                    { 20, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.047933907439425,108.22791950000001", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/347266312_732525068883728_2582077216582628677_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=783fdb&_nc_ohc=OwkHFBKf99sAX_l5Q7f&_nc_ht=scontent.fhan2-4.fna&oh=00_AfA0K4-hT_twY7lB_WsCBK-1GuA7effImnpZeqnVZtEnHA&oe=65734A83", 25f, "KASHI Garden Coffee", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "3 Đảo Xanh 1", 37f, 5 },
                    { 21, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.055502336537142,108.20908984935794", "https://images.foody.vn/res/g1/6625/prof/s576x330/foody-mobile-vp-jpg-351-635998795892251625.jpg", 25f, "Cafe VIP Vườn", new DateTime(2023, 12, 11, 6, 30, 0, 0, DateTimeKind.Unspecified), true, "34 Nguyễn Hữu Thọ", 49f, 8 },
                    { 22, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.056183406126785,108.20687143711115", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/358710498_746997094099364_5694375465150811840_n.jpg?stp=cp6_dst-jpg&_nc_cat=103&ccb=1-7&_nc_sid=efb6e6&_nc_ohc=WKhze04Pun8AX-4Y2K3&_nc_ht=scontent.fhan2-4.fna&oh=00_AfCMRH-EgnRkiVzs1QoaOPZivYZoCouFEx-jObooT_mYOQ&oe=65747891", 35f, "Cafe Huế Xưa", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "1 Thi Sách", 60f, 8 },
                    { 23, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.0695937023709,108.21773447815391", "https://images.foody.vn/res/g2/12434/s800/foody-billiards-379-123544-781-635609101872239771.jpg", 14f, "Billiards 379", new DateTime(2023, 12, 11, 6, 30, 0, 0, DateTimeKind.Unspecified), true, "37-39 Pasteur", 40f, 3 },
                    { 24, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.06994775789383,108.21553603383187", "https://images.foody.vn/res/g10/93915/prof/s640x400/foody-mobile-1522176_143650447324-635466315053025149.jpg", 30f, "Pro Billiards", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "30-32 Chi Lăng", 50f, 4 },
                    { 25, new DateTime(2023, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "16.077586236824075,108.21197804602369", "https://alltop.vn/backend/media/images/posts/1813/CLB_Bida_3C_Da_Lat-99974.jpg", 20f, "Clb Bida 54/2", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "54/2 Ông Ích Khiêm", 40f, 12 },
                    { 26, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.07063231280082,108.22161530799845", "https://images.foody.vn/res/g32/315696/prof/s/foody-mobile-foody-sapphire-billi-852-636193855537572346.jpg", 50f, "Sapphire BIlliard Club", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "42 Phan Đình Phùng", 120f, 3 },
                    { 27, new DateTime(2023, 12, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "16.07063231280082,108.22161530799845", "https://scontent.fhan2-4.fna.fbcdn.net/v/t1.6435-9/71185470_526124794811142_3735501578962993152_n.jpg?stp=dst-jpg_s1080x2048&_nc_cat=111&ccb=1-7&_nc_sid=dd63ad&_nc_ohc=MSaSZ64t9XYAX9brtoT&_nc_ht=scontent.fhan2-4.fna&oh=00_AfAhS7Olz8v_pYz7E_bbDDBgGN-OJLw2Jb-cCxkd0C5rXw&oe=6596C74D", 50f, "134 Billiards Club", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "134 Núi Thành", 80f, 7 },
                    { 28, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.045452104149525,108.22263085165929", "https://bidazoom.com/wp-content/uploads/2021/01/Hai-Chau-Da-Nang-Min-Billiards-Club-27-Duong-2-Thang-9-1.jpg", 40f, "Min Billiards Club", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "263 Đ.2 Tháng 9", 70f, 5 },
                    { 29, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.032733599945665,108.21914776646102", "https://bidazoom.com/wp-content/uploads/2021/01/Hai-Chau-Da-Nang-8Mile-Billiards-Club-108-Xo-Viet-Nghe-Tinh-1.jpg", 40f, "8Mile BIlliards Club", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "108 Xô Viết Nghệ Tĩnh", 70f, 6 },
                    { 30, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.056924410410932,108.21694544692839", "https://images.foody.vn/res/g23/226286/s/foody-new-fai-fo-billiard-club-720-635957290726741496.jpg", 40f, "Billiards New Faifo Club", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "346 Hoàng Diệu", 80f, 1 },
                    { 31, new DateTime(2023, 12, 11, 23, 59, 0, 0, DateTimeKind.Unspecified), "16.047516463353798,108.22242490562897", "https://lh3.googleusercontent.com/p/AF1QipMij5ccb8mtifSmuRtg_-MhgR8TpIzP8JfPWxzd=s1360-w1360-h1020", 80f, "Dan Billiards", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "204-208 Đ.2 Tháng 9", 120f, 5 },
                    { 32, new DateTime(2023, 12, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "16.042413979075384,108.22291293234525", "https://lh3.googleusercontent.com/p/AF1QipMyqVf4gV1u0Ihbr8C6HywEpYU37AoB4Cppv81M=s1360-w1360-h1020", 70f, "5D Billiards Center", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "338 Đ.2 Tháng 9", 100f, 5 },
                    { 33, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.07412217975203,108.21413924639748", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/403732748_362293142987266_4146106978470056177_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=783fdb&_nc_ohc=IGGyzZcAKfIAX8okVWU&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBYd62GhaNHgR9y47QzTdyx-AIt8ebKC5ecmx9AUnzGdA&oe=65740E81", 50f, "Minh Vương Billiards Club", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "376 Đống Đa", 80f, 12 },
                    { 34, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.048645930364334,108.20904468253264", "https://bidazoom.com/wp-content/uploads/2021/01/Hai-Chau-Da-Nang-Mr.-Q-Billiards-Center-2B-Nguyen-Huu-Tho-1.jpg", 20f, "MrQ pool hall", new DateTime(2023, 12, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), true, "38A/3 Nguyễn Hữu Thọ", 50f, 8 },
                    { 35, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.06307705735096,108.21682505433509", "https://bidazoom.com/wp-content/uploads/2021/01/Hai-Chau-Da-Nang-Sao-Billiard-Da-Nang-139-Trieu-Nu-Vuong-1.jpg", 40f, "Clb Bida Sao Billiard", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "139 Triệu Nữ Vương", 70f, 4 },
                    { 36, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.05493105076417,108.2056848642522", "https://images.foody.vn/res/g4/39136/s180x180/foody-chuong-gio-karaoke-886-636033577259263591.jpg", 120f, "Karaoke Chuông Gió", new DateTime(2023, 12, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "2 Man Thiện", 250f, 8 },
                    { 37, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.054749761311733,108.22007030286808", "https://tuantoanaudio.vn/uploads/Images/the-voice.jpg", 80f, "Karaoke The Voice", new DateTime(2023, 12, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), true, "246B Trưng Nữ Vương", 150f, 2 },
                    { 38, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.067320698967585,108.22125270657946", "https://images.foody.vn/res/g2/11883/prof/s/foody-mobile-karaoke-new-life-da-nang.jpg", 80f, "Karaoke Newlife", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "2 Nguyễn Chí Thanh", 165f, 3 },
                    { 39, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.045638249923417,108.21924812646803", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/275925134_101141365888131_8424298429391231942_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=efb6e6&_nc_ohc=Fb076ZR2b0kAX_qKggn&_nc_oc=AQlgYWJgNI3dBh_Wky7l1pwShY98zk56_SRf3_fdlHPjLalXVlnL3nh43QSIcec7a2U&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBQd0e6dhnTbCCfaZrFulJLdMz_Oi1A_LXWwA9vVGzgFA&oe=657582C4", 70f, "Karaoke Giai điệu Tiểu La", new DateTime(2023, 12, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), true, "113 Tiểu La", 165f, 5 },
                    { 40, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.0338150197723,108.21484917474763", "https://images.foody.vn/res/g14/136440/s800/foody-bin-bin-karaoke-huy-can-446-635876119653757753.jpg", 60f, "Karaoke Bin Bin", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "105 Huy Cận", 100f, 6 },
                    { 41, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.080810587349653,108.21452797755114", "https://images.foody.vn/res/g13/124104/prof/s/foody-mobile-foody-suong-chieu-12-248-635611471767406271.jpg", 50f, "Karaoke Sương Chiều", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "3 Thanh Thủy", 200f, 12 },
                    { 42, new DateTime(2023, 12, 11, 0, 30, 0, 0, DateTimeKind.Unspecified), "16.082024473289824,108.21302989392547", "https://product.hstatic.net/1000268128/product/anh_chinh_19a2506026b049b7a93793cf093bcc56_master.jpg", 80f, "Karaoke X.O", new DateTime(2023, 12, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), true, "193A Nguyễn Tất Thành", 120f, 12 },
                    { 43, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.083819730121228,108.21535129289738", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/307754943_776029913368415_1445597095617052911_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=783fdb&_nc_ohc=xIw9EwfDlJAAX-Bvv4s&_nc_ht=scontent.fhan2-3.fna&oh=00_AfCASP7Gtf-hty32E2ri65DN7FeI5DwQHroTaoAFhFfq1g&oe=65755D40", 100f, "Karaoke Wonder", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "133A Nguyễn Tất Thành", 150f, 12 },
                    { 44, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.050110834124176,108.22682828546931", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/320616340_1195829771286627_2888707605744479438_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=SwsP4qjmN90AX-Gi_Db&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBTm_6RMHClpW_H6IqHih58_aM2v6-hLdzExtLimKMMQA&oe=65749A39", 180f, "Karaoke Đảo Xanh KTV", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Lô 5 - A3.5 Khu TMDV Đảo Xanh", 600f, 5 },
                    { 45, new DateTime(2023, 12, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "16.07734100768123,108.21367667424971", "https://images.foody.vn/res/g16/155887/prof/s576x330/foody-mobile-lan-rung-jpg-887-635738458973356534.jpg", 120f, "Karaoke Lan Rừng", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "75 Lý Tự Trọng", 150f, 11 },
                    { 46, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.032922916180272,108.21492889390697", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/358680290_764949142301780_1206754977957980675_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=783fdb&_nc_ohc=ECMNwQu4X6sAX-b7iRw&_nc_ht=scontent.fhan2-4.fna&oh=00_AfA50TIJce0ANQyraRplGjTIeH-pq71sMO-taEHmf1-Xzw&oe=6574A465", 25f, "Tiếng Tơ Đồng", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "215 Huỳnh Tấn Phát", 88f, 6 },
                    { 47, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.036908556981874,108.22600559107303", "https://metiz.vn/media/uploads/2023/06/27/metiz-cinema-02.jpg", 45f, "Metiz Cinema", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Đ.2 Tháng 9", 70f, 5 },
                    { 48, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.035588704701258,108.2313270939811", "https://cdn.alongwalk.info/vn/wp-content/uploads/2022/04/06193951/image-lotte-cinema-da-nang-rap-chieu-phim-hien-dai-dang-cap-164922359082536.jpg", 60f, "Lotte Cinema", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "6 Nại Nam", 85f, 5 },
                    { 49, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.071902704436265,108.22028972627926", "https://baodanang.vn/dataimages/201912/original/images1537566_DSC_3514.JPG", 30f, "Rạp chiếu phim Lê Độ", new DateTime(2023, 12, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), true, "46 Trần Phú", 50f, 3 },
                    { 50, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.056703263219344,108.22079839307933", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/401592418_831631462300937_883802411599895605_n.jpg?stp=cp6_dst-jpg&_nc_cat=105&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=_fnLwCHmDsMAX8aiFtX&_nc_ht=scontent.fhan2-4.fna&oh=00_AfCiqinW_L_Qhh7gvGwhH2H_Kb6Z4WglTcs1-TgaBV0FYQ&oe=6574837E", 99f, "Mini Cinema & Couple Event Zone7", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "27 Đào Tấn", 399f, 1 },
                    { 51, new DateTime(2023, 12, 11, 2, 30, 0, 0, DateTimeKind.Unspecified), "16.03426988462426,108.2156735270143", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/393254138_813643834099700_2138770943013154073_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=-n5BCUJsgWEAX9KDosh&_nc_ht=scontent.fhan2-3.fna&oh=00_AfCBRfA8VjkibE1jGGayb7B29wyST3hz1N1tAietXVz_9g&oe=6574E8B6", 99f, "CineBox & Dating Zone7+", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "160 Tố Hữu", 449f, 6 },
                    { 52, new DateTime(2023, 12, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), "16.06155409077922,108.2173688650634", "https://media.foody.vn/BlogsContents/foody-ga-spa-44611-322-636677106928567978.jpg", 299f, "Gà Spa", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "179b Triệu Nữ Vương", 990f, 9 },
                    { 53, new DateTime(2023, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "16.066291281495637,108.22257009933693", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/380655158_715038250639482_7799090381496683862_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=efb6e6&_nc_ohc=PFeoqxvBL7MAX9CokQm&_nc_ht=scontent.fhan2-4.fna&oh=00_AfAKAkW_zjBYxQLnmOBx_QJ9QB2tZ4CO5CWaHSnQCFadWg&oe=65753614", 250f, "Spa Viện CO2", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "117 Phan Châu Trinh", 1500f, 10 },
                    { 54, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.05435876299563,108.2215622544207", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/405308808_854574366670017_1673951635162137549_n.jpg?stp=dst-jpg_s960x960&_nc_cat=111&ccb=1-7&_nc_sid=3635dc&_nc_ohc=EZCXAq1x9SgAX90dDPR&_nc_ht=scontent.fhan2-4.fna&oh=00_AfDM-haOwlsWB_nDtsrDW30IUbOtP0LTXvajF9ghZR44Cw&oe=6575CD71", 70f, "B Spa", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "15 Núi Thành", 550f, 7 },
                    { 55, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.05509634366035,108.22193509988948", "https://saigonspamassage.com/wp-content/uploads/2022/12/ffed875c603cb862e12d3.jpg", 120f, "Sai Gon Spa Massage", new DateTime(2023, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "8 Núi Thành", 499f, 2 },
                    { 56, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.06135447859589,108.21778141412001", "https://www.belasspa.com/Data/Sites/1/ImageGallery/107/avt-cc-dd.jpg", 499f, "Belas Spa", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "60 Nguyễn Văn Linh", 6999f, 9 },
                    { 57, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.045175801430364,108.22406083796174", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/372981146_270143282492728_185860399485785076_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=vclIOjU_tHsAX8D15Zo&_nc_ht=scontent.fhan2-3.fna&oh=00_AfDEA8hKp74JC_OGRYMgj-YSeQFhEQM1BuSxVvcCutrRMA&oe=6575526E", 79f, "Sam Beauty Spa", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "23 Nguyễn Sơn Trà", 499f, 5 },
                    { 58, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.065592223272045,108.22287977660238", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0d/0b/f4/87/view-of-charm.jpg?w=1200&h=-1&s=1", 150f, "Charm Spa", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "283 Nguyễn Chí Thanh", 1750f, 10 },
                    { 59, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.04610111828616,108.22570466181014", "https://images.foody.vn/video/s800x450/foody-upload-api-foody-foody-upload-api-foody-album1-1-jpg-18091417-181025173256.jpg", 199f, "An Spa", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Lô 4-A9.4 đường 2/9", 699f, 5 },
                    { 60, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.066593102034172,108.22450963908354", "https://lh3.googleusercontent.com/p/AF1QipNbXJQzZaIweSR-WTTMDtN6UpBnZ65tCWkbD5SR=s3072-w3072-h1414-rw", 50f, "Anna Spa", new DateTime(2023, 12, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), true, "11A Trần Quốc Toản", 599f, 10 },
                    { 61, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.082036317582038,108.22186418400092", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/301350274_512862437511173_3344663491923273738_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=783fdb&_nc_ohc=abZdf-wOspkAX_4t5Lc&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBp82-n3muQWeBXhEV_bJZFEmQLTa32HT8Ka5m-PTf4Gg&oe=6575A965", 89f, "Miss Gia Han Spa", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "61 Trần Quý Cáp", 1099f, 11 },
                    { 62, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.077742454160177,108.21092309194869", "https://images.toplist.vn/images/800px/bovis-spa-da-nang-942354.jpg", 200f, "Bovis Spa cs1", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "22/8 Bắc Đẩu", 899f, 12 },
                    { 63, new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "16.06379250930651,108.22247802318384", "https://akinacenter.com/wp-content/uploads/2022/01/cos3.jpg", 699f, "Akina Center", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "54 Hoàng Văn Thụ", 14999f, 10 },
                    { 64, new DateTime(2023, 12, 11, 20, 30, 0, 0, DateTimeKind.Unspecified), "16.076290922653204,108.22185246977068", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/241407364_1509337262761803_6323789033921668967_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=783fdb&_nc_ohc=KutoRl1hrAsAX86uGqr&_nc_ht=scontent.fhan2-4.fna&oh=00_AfAG6xRCXxR6UQCCzLlQvhwFpCg68yKIrnhahlke-aGhsQ&oe=65763C5E", 249f, "Spa NQ", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "89 Nguyễn Chí Thanh", 1499f, 11 },
                    { 65, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.06191909605416,108.21601990044891", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/317822484_6335459383145497_1434827925992790768_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=M4k3FmTpCjEAX9gWVZn&_nc_ht=scontent.fhan2-3.fna&oh=00_AfDT8GpJQ2uoheLz1nKXHlcF7_oQffDtBbdbvUGTsFeXRA&oe=65756053", 119f, "Linh Spa Beauty & Academy", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "K82 H10/11 Đ Nguyễn Văn Linh", 3500f, 9 },
                    { 66, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.06581631696931,108.22540185386798", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/18/cd/0d/32/interior-space-at-golden.jpg?w=1200&h=-1&s=1", 180f, "Golden Lotus Oriental Organic Spa", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "209 Trần Phú", 990f, 10 },
                    { 67, new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), "16.057519898726582,108.21902123057387", "https://oms.hotdeal.vn/images/editors/sources/000366474481/366474-Vivian-DN-Spa-Xong-hoi-da-muoi-massage-body-da-nong-body(18).jpg", 59f, "ViviAn Spa", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "42/356 Hoàng Diệu", 499f, 2 },
                    { 68, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.063230131627083,108.22457042318366", "https://images.toplist.vn/images/800px/la-hair-spa-884947.jpg", 59f, "Lá Hair Spa", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "3 Hoàng Văn Thụ", 149f, 10 },
                    { 69, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.05711213569866,108.2139111544217", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/288153707_522648249649530_7229461669982591672_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=783fdb&_nc_ohc=P6GIF5VZVgwAX96R8gZ&_nc_ht=scontent.fhan2-4.fna&oh=00_AfDk65ROirf4BFIEBhXz3IJKzNi6Z7FZqXIyjD_sG1YT4Q&oe=657503EF", 149f, "Le.O Spa", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "344 Nguyễn Hoàng", 7999f, 1 },
                    { 70, new DateTime(2023, 12, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), "16.064291067601218,108.22237020839904", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/308785236_620818833032158_4117532416583277552_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=783fdb&_nc_ohc=YXk24mVNhrEAX_UJocE&_nc_ht=scontent.fhan2-4.fna&oh=00_AfCbmQDg-10wC8fGFCzCeAvADlG8pJvwXYLAkk-jTbt-BA&oe=65752A07", 89f, "Le Chillies Spa", new DateTime(2023, 12, 11, 8, 30, 0, 0, DateTimeKind.Unspecified), true, "31 Lê Hồng Phong", 299f, 10 },
                    { 71, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.034146226348895,108.22088629248913", "https://lh3.googleusercontent.com/p/AF1QipPYOO2tVfyNgO1PIZK_llgP_Qz2h1ZxaYsI-9ah=s1360-w1360-h1020", 250f, "An Yên Beauty & Spa", new DateTime(2023, 12, 11, 7, 30, 0, 0, DateTimeKind.Unspecified), true, "32 Huy Cận", 1500f, 6 },
                    { 72, new DateTime(2023, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), "16.042686693983004,108.21792699308851", "https://lh3.googleusercontent.com/p/AF1QipNs5TyL2t3ucGXMyGfYb0cfWA2r5ZdqbtQriNnV=s1360-w1360-h1020", 30f, "Bánh đa cua Thu Yến", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "68 Lê Thanh Nghị", 50f, 5 },
                    { 73, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.069038277689057,108.21447441029056", "https://www.wikidanang.com/tin-tuc/images/Wiki/quan-an/tiem-an-cho-lon/tiem-an-cho-lon-oik-1.jpg", 50f, "Tiệm ăn Chợ Lớn", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "267 Ông Ích Khiêm", 350f, 4 },
                    { 74, new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "16.05636675681497,108.22103680100315", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/404839931_310943938444395_5953591676962366924_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=3635dc&_nc_ohc=QEeT5mHXc6EAX_7t7GF&_nc_oc=AQljWCF2XmN19RHiBU1iv6ESLSMXW5I2PCWInJ-AfypOp8DF6cVKWW3EsdU_wXjGZ4M&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBgGAerl7HRxE5Wrji6UBEsDTCsaTrBiI2flmaAS5SJjw&oe=6575D6AF", 50f, "Cơm nhà Kiều thị", new DateTime(2023, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "68-70 Đ.2 Tháng 9", 250f, 1 },
                    { 75, new DateTime(2023, 12, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), "16.060017239099555,108.21390069354865", "https://lh5.googleusercontent.com/p/AF1QipPpuc5K-UQPTo8TzI7qW1BWvVKI-aeisSFlezME=w408-h306-k-no", 40f, "Cơm gà Tài Ký", new DateTime(2023, 12, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), true, "188 Nguyễn Hoàng", 70f, 9 },
                    { 76, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.048360224032354,108.21043015447276", "https://lh5.googleusercontent.com/p/AF1QipM12jb2kvt40hDbk6U2qL3TTYesqg4vCPeDJpWe=w408-h306-k-no", 79f, "Dê núi Ninh Bình", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "113 Nguyễn Hữu Thọ", 899f, 8 },
                    { 77, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.035291421432603,108.21498365076145", "https://lh5.googleusercontent.com/p/AF1QipN_LVrd-nPFGvtmBduM69IgfsFcu1TmNDEQdgYK=w408-h306-k-no", 50f, "Quán 129", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "129 Huỳnh Tấn Phát", 200f, 6 },
                    { 78, new DateTime(2023, 12, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), "16.057969515296527,108.22088450893641", "https://lh5.googleusercontent.com/p/AF1QipOQ9rwx0Q0kcbm_IulsIcOCuUj48uOufulES3DK=w408-h544-k-no", 25f, "Quán Đại Lộc", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "97 Trưng Nữ Vương", 65f, 1 },
                    { 79, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.053165120941944,108.22205543069205", "https://lh5.googleusercontent.com/p/AF1QipPwubv13tFELBO2JhpSciPCxs5jLXgNauO5596M=w408-h306-k-no", 30f, "Quán ăn Nhà Ta", new DateTime(2023, 12, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), true, "134 Đ.2 Tháng 9", 80f, 7 },
                    { 80, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.065775688615943,108.22251776706132", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/341620333_566732878969762_2510917306260210918_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=j6DTzMO96ZUAX8j_xfv&_nc_ht=scontent.fhan2-3.fna&oh=00_AfACX5WDH49WiV_Zz1UmXUwg5uqve0-5BbzJi1zLjjUTfA&oe=65768346", 80f, "Nhà hàng Hai Cử", new DateTime(2023, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "63 Yên Bái", 250f, 10 },
                    { 81, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.07617127961935,108.21404178004062", "https://lh5.googleusercontent.com/p/AF1QipOo261B1O-hQSHu-sBohpNrc9sRGFfad3nHiiC2=w408-h306-k-no", 50f, "Quán ăn Ngọc Ký", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "225 Đống Đa", 65f, 11 },
                    { 82, new DateTime(2023, 12, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), "16.05478060389454,108.22055675396189", "https://images.foody.vn/res/g23/229945/s/foody-an-vat-3colu-799-636092898295352083.jpg", 25f, "Ăn vặt 3colu", new DateTime(2023, 12, 11, 15, 30, 0, 0, DateTimeKind.Unspecified), true, "36 Nguyễn Bá Học", 70f, 2 },
                    { 83, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.051218448049585,108.21300803069205", "https://lh5.googleusercontent.com/p/AF1QipNcFEdVQz2Hg4oJfJ_Eisjkunm1dlUACM-d4FiW=w408-h306-k-no", 59f, "Nướng Bơ 1986", new DateTime(2023, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "301 Nguyễn Tri Phương", 139f, 7 },
                    { 84, new DateTime(2023, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "16.053666160736466,108.21909618055149", "https://images.foody.vn/res/g10/97033/s400x400/foody-mau-con-banh-trang-thit-heo-762-636551009641519497.jpg", 80f, "Quán Mậu Con", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "215 Trưng Nữ Vương", 120f, 7 },
                    { 85, new DateTime(2023, 12, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "16.051041697781752,108.22074318211641", "https://images.foody.vn/res/g73/720708/s800/foody-chan-ga-nuong-hai-coi-ngo-thi-nham-664-637121807664901230.jpg", 70f, "Chân gà nướng Hai Còi", new DateTime(2023, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "77 Núi Thành", 100f, 7 },
                    { 86, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.06075784973397,108.22051066706125", "https://images.foody.vn/res/g4/39409/prof/s/foody-mobile-foody-lau-nuong-ui-c-379-635893995672141706.jpg", 12f, "Ui Chao Lẩu Nướng", new DateTime(2023, 12, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "57 Nguyễn Văn Linh", 119f, 1 },
                    { 87, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.04206004015618,108.22225474007983", "https://images.foody.vn/res/g1/8845/s400x400/foody-hoa-map-quan-ca-duoi-nuong-975-636597521916151813.jpg", 40f, "Quán Hoa Mập", new DateTime(2023, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "344 Đ.2 Tháng 9", 250f, 5 },
                    { 88, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.055198670903522,108.22153449589766", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/298958925_553753416545803_5175106742243845066_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=efb6e6&_nc_ohc=bYpqO5PNtREAX88HKq9&_nc_ht=scontent.fhan2-3.fna&oh=00_AfAy0gL6Fuu_xOMRtDdW3_CdacFUsmmbufnA0d-Aa60UZw&oe=6575CC9E", 35f, "Quán Đông Tây", new DateTime(2023, 12, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "17 Bình Minh 1", 220f, 2 },
                    { 89, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.05430863754228,108.21867379999999", "https://lh5.googleusercontent.com/p/AF1QipP5kVdboRRdOWcsWdd--Mbh27xPFazt41TiLZTT=w408-h408-k-no", 25f, "Quán chay Hỷ Lạc", new DateTime(2023, 12, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), true, "378 Phan Châu Trinh", 40f, 2 },
                    { 90, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.043451609759344,108.22150555396189", "https://images.foody.vn/res/g13/128805/s/foody-lau-bo-128805-967-635635929915781091.jpg", 35f, "Lẩu bò A Trung", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "267/2 Núi Thành", 280f, 5 },
                    { 91, new DateTime(2023, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "16.042221093769164,108.21780747035142", "https://images.foody.vn/res/g8/72565/prof/s576x330/foody-mobile-foody-quan-nhau-heo--548-635981433966486776.jpg", 45f, "Quán Heo Tộc", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "81 Lê Thanh Nghị", 100f, 5 },
                    { 92, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.065136832437986,108.22453077959847", "https://onedanang.vn/Content/UserUploads/Images/Locations/4/ImageContent/fgwrfew.PNG", 50f, "Bamboo 2 Bar", new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), true, "216 Bạch Đằng", 6400f, 10 },
                    { 93, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.073116416782785,108.22068528937801", "https://toplist.vn/images/800px/chut-chill-cocktails-amp-beer-1120870.jpg", 70f, "Chút Chill", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "165 Lê Lợi", 3000f, 3 },
                    { 94, new DateTime(2023, 12, 11, 12, 30, 0, 0, DateTimeKind.Unspecified), "16.06297667430682,108.22041751771273", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/399618434_317505447687792_3197544934014415246_n.png?_nc_cat=110&ccb=1-7&_nc_sid=783fdb&_nc_ohc=TyQtHhcsgFsAX9mjKYd&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBZqXKdgit1jqOZiau4_YjPQOFK7HWqm1HfWgp5_iPslw&oe=6574FB26", 130f, "Bar Đồ Yêu", new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), true, "87 Hoàng Văn Thụ", 200f, 10 },
                    { 95, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.066417190203097,108.22447584890641", "https://lh3.googleusercontent.com/p/AF1QipMzjMqr3f4tt4dvZBxGD1QFQO72Xqbuo4o8F6D8=s1360-w1360-h1020", 1490f, "Hair Of The Dog Bar", new DateTime(2023, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), true, "6 Trần Quốc Toản", 5380f, 3 },
                    { 96, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.06539973223335,108.2220051544731", "https://chillvietnam.com/wp-content/uploads/2022/10/on-the-radio-bar-chut-co-dien-day-tinh-te-tai-da-nang-1666184428.jpg", 50f, "On The Radio Bar", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "76 Thái Phiên", 1200f, 10 },
                    { 97, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.065432081430007,108.22440754890637", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/290016665_1493689091091025_4765718037992447549_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=efb6e6&_nc_ohc=9KolDh7Su9EAX9-feYQ&_nc_ht=scontent.fhan2-4.fna&oh=00_AfCLSWAcGJEAEG649ui6EybtHcCXU5Rgw71uhpQ2CU8gRg&oe=65756E80", 80f, "The Dude Bar", new DateTime(2023, 12, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), true, "210 Bạch Đằng", 2990f, 10 },
                    { 98, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.06807602044494,108.2238111470509", "https://chillvietnam.com/wp-content/uploads/2022/10/te-bar-da-nangchon-thien-duong-xu-da-thanh-1666075093-1024x683.jpg", 50f, "Tê Bar", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "39-41 Nguyễn Thái Học", 600f, 3 },
                    { 99, new DateTime(2023, 12, 11, 3, 30, 0, 0, DateTimeKind.Unspecified), "16.046097025557202,108.2250986656061", "https://chillvietnam.com/wp-content/uploads/elementor/thumbs/adm-club-da-nang-1685186118-q72bgc2kfs1nkcp3mox82wqqtqg8uejwfcepm199k8.jpg", 200f, "ADM Bar Club", new DateTime(2023, 12, 11, 20, 30, 0, 0, DateTimeKind.Unspecified), true, "Lô 1-A9.4 Khu Công viên Bắc Đài tưởng niệm", 10000f, 5 },
                    { 100, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.066918289657398,108.22509057774296", "https://media-cdn.tripadvisor.com/media/photo-s/13/57/0d/c4/brilliant-top-bar-outside.jpg", 150f, "Brilliant Top Bar", new DateTime(2023, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), true, "162 Bạch Đằng", 5990f, 3 },
                    { 101, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.067173221100784,108.22518089123342", "https://chillvietnam.com/wp-content/uploads/2022/10/sophie-mixology-kham-pha-vung-dat-am-nhac-da-thanh-1666427828.jpg", 90f, "Sophie Mixology", new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), true, "150 Bạch Đằng", 1450f, 3 },
                    { 102, new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), "16.07278378864266,108.2216814968003", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/355693517_991595998860380_4817188430646017212_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=783fdb&_nc_ohc=PeiLU2m3oZoAX8aO6QA&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBfCDyNesPOTIL2YNRqdhFgFkWCrRTohUn32UvRxHW_ig&oe=6574B30D", 180f, "LIBRE Bar", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "125a Nguyễn Chí Thanh", 2000f, 3 },
                    { 103, new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), "16.066251590383494,108.2210997335604", "https://media-cdn.tripadvisor.com/media/photo-s/2a/aa/d1/02/nightfall-at-the-beautiful.jpg", 60f, "MAKARA", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "162a Nguyễn Chí Thanh", 499f, 10 },
                    { 104, new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), "16.065917280926787,108.22421285076197", "https://media-cdn.tripadvisor.com/media/photo-s/26/5a/c2/06/enjoy-our-special-cocktail.jpg", 79f, "Time Cocktail Bar & Eatery", new DateTime(2023, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "195 Trần Phú", 699f, 10 },
                    { 105, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.080735867114075,108.22111832428301", "https://lh3.googleusercontent.com/p/AF1QipOKHyxfsBmHGw-XtgNy2bWc7fMCz-twpD_nQGg=s1360-w1360-h1020", 119f, "Nóc Nóc-Cocktails & Tea", new DateTime(2023, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "2/4 Phan Bội Châu", 499f, 11 },
                    { 106, new DateTime(2023, 12, 11, 1, 30, 0, 0, DateTimeKind.Unspecified), "16.08126465597531,108.22004976610833", "https://chillvietnam.com/wp-content/uploads/elementor/thumbs/293689526_538416394749270_9133345411021438910_n-q0n075nxq27oa1l15mmz8n8o1tpwxu2109y5e5sqeg.jpg", 60f, "Tailor Bar", new DateTime(2023, 12, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), true, "57 Trần Quý Cáp", 3000f, 11 },
                    { 107, new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), "16.06504515223653,108.22086633356041", "https://danalocal.info/wp-content/uploads/2023/07/van-cocktaik-bar-quan-bar-nho-xinh-cuc-chill-danh-cho-team-huong-noi-7-1.jpg", 119f, "Vấn Cocktail Bar", new DateTime(2023, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "180-182 Nguyễn Chí Thanh", 899f, 10 },
                    { 108, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.060901135733484,108.2201161247841", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/401675534_321422717305286_771825975568127139_n.jpg?stp=cp6_dst-jpg&_nc_cat=111&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=5JXNsSCc6dMAX-s-TRJ&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBgIcAoXvw4-MhrODA-r3IlvoEJyjtjxt047NJJ9Ct_pQ&oe=65752471", 299f, "P.Antheon Cocktail Bar", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "53-55 Nguyễn Văn Linh", 4990f, 9 },
                    { 109, new DateTime(2023, 12, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), "16.068832190899162,108.22334050286848", "https://vietnamnightlife.com/uploads/images/2023/01/1674032972-multi_product20-eazyddanangoverview4.jpg", 2500f, "EAZY D", new DateTime(2023, 12, 11, 20, 30, 0, 0, DateTimeKind.Unspecified), true, "72-74 Hùng Vương", 32000f, 3 },
                    { 110, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.082598509890545,108.21974416796382", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/400441958_713937547455115_2089794329145735889_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=783fdb&_nc_ohc=SjG8e2VWqGoAX8_KMkU&_nc_oc=AQlaUL1DI_5Zjdc-FYHM2JWsHP0L7M9G6Ezy4L9nmLSmyPo8VNkAflMYhHpkW4BwZK8&_nc_ht=scontent.fhan2-4.fna&oh=00_AfCjF7vW-MGNPMOU6cr0YAyq3kze2jvRB8EVGc6feunuOQ&oe=657602D5", 149f, "Linger - Bespoke Cocktail Bar", new DateTime(2023, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "19 Phan Kế Bình", 1999f, 13 },
                    { 111, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.08273776347041,108.22143346425271", "https://lh3.googleusercontent.com/p/AF1QipPjUFkK4YnOB3_a7UOMzMLTEEU1ZzjgzyytcG1b=s1360-w1360-h1020", 400f, "Bar New Phương Đông", new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), true, "20 Đống Đa", 2200f, 13 },
                    { 112, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.077617478000473,108.22435529494474", "https://lh3.googleusercontent.com/p/AF1QipPdv021DePW2a7HLghz_5zqsUj0kSoqRT6iVU7K=s1360-w1360-h1020", 200f, "Sky 36", new DateTime(2023, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "36 Bạch Đằng", 500f, 11 },
                    { 113, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.066664004900694,108.22595319626632", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/279709176_3080899275555546_684331376012139486_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=kRa8V-wMsHgAX-35XnB&_nc_ht=scontent.fhan2-3.fna&oh=00_AfDB68GT1N-8intnVP_aNAf6a_R_Ma5FFihhS_5qyY81tQ&oe=657588F1", 45f, "Sky Pub", new DateTime(2023, 12, 11, 4, 0, 0, 0, DateTimeKind.Unspecified), true, "214 Bạch Đằng", 2199f, 10 },
                    { 114, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.079726821079966,108.2242206526177", "https://images.foody.vn/res/g9/83215/prof/s/foody-mobile-a-jpg-383-635779336904347422.jpg", 200f, "Oq Lounge Pub", new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), true, "18 Bạch Đằng", 500f, 11 },
                    { 115, new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), "16.06643420977416,108.22239383541596", "https://images.foody.vn/res/g72/712161/prof/s/foody-mobile-1920-jpg.jpg", 190f, "The 1920’s Lounge", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "53 Trần Quốc Toản", 230f, 10 },
                    { 116, new DateTime(2023, 12, 11, 1, 0, 0, 0, DateTimeKind.Unspecified), "16.07971932108589,108.22191341821464", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/296862147_113866774749314_890281081296464994_n.jpg?stp=cp6_dst-jpg&_nc_cat=102&ccb=1-7&_nc_sid=783fdb&_nc_ohc=CWSxa3k6nfYAX8qoqPj&_nc_ht=scontent.fhan2-3.fna&oh=00_AfCfmv3yhIVq3xlhhaiSz-IWIuEIgp333Glary-dwmytUg&oe=65760049", 72f, "S Counter & Lounge", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "15 Phan Bội Châu", 4032f, 11 },
                    { 117, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.063621313129065,108.22095976375073", "https://chillvietnam.com/wp-content/uploads/2022/10/playboy-chill-lounge-quan-bar-da-nang-hap-dan-1667081887.jpg", 80f, "Playboy Chill Lounge", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "177 Phan Châu Trinh", 7990f, 10 },
                    { 118, new DateTime(2023, 12, 11, 2, 0, 0, 0, DateTimeKind.Unspecified), "16.079964620894756,108.22283585582733", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/397885172_307978292026286_7631601059683141725_n.jpg?stp=cp6_dst-jpg&_nc_cat=103&ccb=1-7&_nc_sid=dd5e9f&_nc_ohc=-cpTn1HMLtQAX9_Gmmj&_nc_ht=scontent.fhan2-4.fna&oh=00_AfBfXwZ5ktMWI6818dZ5VECOC-YWJOOHkHKqhTN_y2sbkQ&oe=657627C7", 50f, "Royal Counter & Lounge", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "11a Phan Bội Châu", 2990f, 11 },
                    { 119, new DateTime(2023, 12, 11, 4, 0, 0, 0, DateTimeKind.Unspecified), "16.06639696083888,108.22501401956838", "https://chillvietnam.com/wp-content/uploads/elementor/thumbs/karma-lounge-da-nang-khu-vui-choi-khong-the-bo-lo-1667244630-q0n0gk1u2f2wdnxi9owo69ulwje1wvdeassy5rv06g.jpg", 95f, "Karma Lounge", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "6 Trần Quốc Toản", 9000f, 3 },
                    { 120, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.0659127103963,108.2227081335604", "https://chillvietnam.com/wp-content/uploads/elementor/thumbs/nuna-lounge-quan-bar-hap-dan-voi-gioi-tre-da-thanh-1667083264-q0n0gk1u2f2wdnxi9owo69ulwje1wvdeassy5rv06g.jpg", 60f, "Nuna Lounge", new DateTime(2023, 12, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), true, "100 Yên Bái", 11890f, 10 },
                    { 121, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.08257035468743,108.22065082984959", "https://chillvietnam.com/wp-content/uploads/2023/05/carol-lounge-da-nang-1685191121-1024x683.jpg", 200f, "Carol Lounge", new DateTime(2023, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "28d Đống Đa", 10000f, 13 },
                    { 122, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "16.06632462171712,108.22499669494454", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/369730762_270741869048520_1220285891420103496_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=3635dc&_nc_ohc=J9ZYWmErBF8AX-6EKxv&_nc_ht=scontent.fhan2-4.fna&oh=00_AfCDd8ImRU6cFXab_r5s5KpmGQgA9sEMwRG6kL0lhbjjdg&oe=6575F714", 100f, "NYX Sky Lounge & Mixology", new DateTime(2023, 12, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), true, "182 Bạch Đằng", 9000f, 3 },
                    { 123, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.079251884947773,108.22200491821464", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/329871953_903119557562821_3776202290467868563_n.jpg?stp=cp6_dst-jpg&_nc_cat=102&ccb=1-7&_nc_sid=783fdb&_nc_ohc=Tfjl_r_iuzIAX_yKrFE&_nc_ht=scontent.fhan2-3.fna&oh=00_AfDlGKxRwEbGN-j4NpKP2kPoYEa0FIovspaKEpBAUJypgw&oe=6575247E", 70f, "SUGAR Counter & Lounge", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "35 Phan Bội Châu", 6990f, 11 },
                    { 124, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.065635232050074,108.22481302749208", "https://chillvietnam.com/wp-content/uploads/2022/10/kyoto-lounge-cau-lac-bo-dem-soi-dong-nhat-da-thanh-1666830695-1024x684.jpg", 50f, "Kyoto Lounge", new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), true, "202 Bạch Đằng", 8990f, 10 },
                    { 125, new DateTime(2023, 12, 11, 22, 30, 0, 0, DateTimeKind.Unspecified), "16.072909426388463,108.22545604705111", "https://media.mia.vn/uploads/blog-du-lich/memory-lounge-da-nang-chiec-la-khong-lo-ben-canh-song-han-4-1636483013.jpg", 65f, "Memory Lounge", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "7 Bạch Đằng", 155f, 3 },
                    { 126, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.080148166159102,108.22204792192582", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/384512523_831201482340054_4028213134785477835_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=783fdb&_nc_ohc=IsWbYvkf6wwAX9fosn6&_nc_ht=scontent.fhan2-4.fna&oh=00_AfB6QKCRG02N5irMr2-XKuWpXJ3PwebJbA93LUk5Sj1L5g&oe=65762B80", 150f, "GINZA Bar & Lounge", new DateTime(2023, 12, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), true, "9 Phan Bội Châu", 7990f, 11 },
                    { 127, new DateTime(2023, 12, 11, 3, 0, 0, 0, DateTimeKind.Unspecified), "16.079152094598943,108.2220984200702", "https://chillvietnam.com/wp-content/uploads/2022/10/bunny-bar-lounge-2-diem-den-yeu-thich-cua-gioi-tre-da-nang-1666297821-1024x730.jpg", 300f, "BUNNY Bar & Lounge 2", new DateTime(2023, 12, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), true, "12 Nguyễn Du", 1000f, 11 },
                    { 128, new DateTime(2023, 12, 11, 23, 59, 0, 0, DateTimeKind.Unspecified), "16.04172532868521,108.21377360331951", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/315655972_579388297326736_7776215781165280937_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=efb6e6&_nc_ohc=iKwjqrWTfWwAX967lL0&_nc_oc=AQkBkC5JnTvtdWuxOM0wGlWcY5QaCEafe-4WQEd4rSIzDMA5puDOyjyV7TdxTMXfHpw&_nc_ht=scontent.fhan2-3.fna&oh=00_AfBilDVSz2CPAZybWK8p_mshRQcm5XjMq5_lz-nBejsXeQ&oe=6575D4E5", 20f, "ESPORT GAMING MUNET", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "94-96 Nguyễn Hữu Dật", 50f, 5 },
                    { 129, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.032866492018023,108.22095030541594", "https://cybercore.vn/wp-content/uploads/2020/07/Enscape_2020-06-30-17-46-50.jpg", 12f, "CyberCore Gaming King Kong", new DateTime(2023, 12, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), true, "128 Xô Viết Nghệ Tĩnh", 50f, 6 },
                    { 130, new DateTime(2023, 12, 11, 23, 59, 0, 0, DateTimeKind.Unspecified), "16.03673000292979,108.21711605195561", "https://cybercore.vn/wp-content/uploads/2019/07/GPM_5719.jpg", 24f, "CyberCore D.C Gaming", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "172 Phan Đăng Lưu", 55f, 5 },
                    { 131, new DateTime(2023, 12, 11, 23, 59, 0, 0, DateTimeKind.Unspecified), "16.033215383589294,108.22339416629849", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7MpEd56jDgUEXZlmmxNHew3OI_fI4qvdyGA&usqp=CAU", 28f, "Cyber Lip Béo Gaming", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "78 Xô Viết Nghệ Tĩnh", 48f, 6 },
                    { 132, new DateTime(2023, 12, 11, 23, 59, 0, 0, DateTimeKind.Unspecified), "16.033163129818803,108.22111523660958", "https://scontent.fhan2-4.fna.fbcdn.net/v/t39.30808-6/405910957_365982802486080_6631294215094903556_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=3635dc&_nc_ohc=YLYYjEx9jaoAX_bKFyV&_nc_ht=scontent.fhan2-4.fna&oh=00_AfDVcKBXb-CByBuKsCNrrmf6PQcgXmDiEjyVAWwBiJI5_g&oe=6574A007", 12f, "2L Cyber Gaming iCafe", new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "108 Xô Viết Nghệ Tĩnh", 70f, 6 },
                    { 133, new DateTime(2023, 12, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), "16.078590589123483,108.21901176730164", "https://disanmientrung.vn/uploads/import/restaurant/909449/foody-upload-api-foody-mobile-ngo1-190424171437.jpg", 15f, "Ngạo Mõ ICafe", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "147-149 Đống Đa", 40f, 11 },
                    { 134, new DateTime(2023, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), "16.07806017021066,108.2098008143429", "https://images.foody.vn/res/g99/985370/prof/s/foody-upload-api-foody-mobile-hmzz-200109112702.jpg", 25f, "Tổ ikafé", new DateTime(2023, 12, 11, 7, 0, 0, 0, DateTimeKind.Unspecified), true, "357 Nguyễn Tất Thành", 50f, 12 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VenueManagers_Roles_RoleId",
                table: "VenueManagers",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VenueManagers_Venues_VenueId",
                table: "VenueManagers",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueManagers_Roles_RoleId",
                table: "VenueManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueManagers_Venues_VenueId",
                table: "VenueManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VenueManagers",
                table: "VenueManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Wards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SaltPassword",
                table: "VenueManagers");

            migrationBuilder.DropColumn(
                name: "SaltPassword",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "VenueManagers",
                newName: "VenueManager");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_VenueManagers_VenueId",
                table: "VenueManager",
                newName: "IX_VenueManager_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_VenueManagers_RoleId",
                table: "VenueManager",
                newName: "IX_VenueManager_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "User",
                newName: "IX_User_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VenueManager",
                table: "VenueManager",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Roles_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VenueManager_Roles_RoleId",
                table: "VenueManager",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VenueManager_Venues_VenueId",
                table: "VenueManager",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
