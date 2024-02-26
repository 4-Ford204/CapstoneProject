﻿// <auto-generated />
using System;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("HashPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoginVia")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<byte[]>("SaltPassword")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = new DateTime(2002, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
<<<<<<< Updated upstream
                            CreateDate = new DateTime(2024, 2, 26, 18, 35, 38, 71, DateTimeKind.Local).AddTicks(7361),
=======
                            CreateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9336),
>>>>>>> Stashed changes
                            Email = "huynhduy20042002@gmail.com",
                            FirstName = "Duy",
                            Gender = true,
<<<<<<< Updated upstream
                            HashPassword = "C7F8CDB9CDB219B92CDA0CDB4FAA2F4C5B9F86C99F26E4BB5EA62E04F765CE897FC4A91C0AFEF67837EC7206829E39696F1F3D44B1A8D80E8BD0AB56BBFCF5B1",
                            Image = "~/Image/Administrator/SuperAdmin.jpg",
                            IsEmailConfirmed = false,
                            LastName = "Lê Tự Huỳnh",
                            LastUpdateDate = new DateTime(2024, 2, 26, 18, 35, 38, 71, DateTimeKind.Local).AddTicks(7384),
                            LoginVia = 1,
                            PhoneNumber = "0875871444",
                            RoleId = 1,
                            SaltPassword = new byte[] { 228, 142, 240, 230, 218, 220, 195, 2, 2, 240, 18, 123, 124, 150, 217, 21, 178, 229, 67, 98, 19, 246, 223, 238, 23, 53, 52, 176, 245, 11, 169, 161, 118, 111, 137, 227, 145, 59, 232, 115, 54, 9, 18, 218, 118, 37, 110, 65, 126, 36, 29, 25, 66, 69, 159, 191, 193, 138, 127, 238, 231, 34, 14, 254 },
                            Status = true
=======
                            HashPassword = "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F",
                            Image = "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg",
                            IsEmailConfirmed = false,
                            LastName = "Lê Tự Huỳnh",
                            LastUpdateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9351),
                            LoginMethod = 1,
                            PhoneNumber = "0118138278",
                            RoleId = 1,
                            SaltPassword = new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 },
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            BirthDay = new DateTime(2002, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9421),
                            Email = "phuchvde160270@fpt.edu.vn",
                            FirstName = "Phúc",
                            FullName = "Phúc Hồ Văn",
                            Gender = true,
                            HashPassword = "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F",
                            Image = "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg",
                            IsEmailConfirmed = false,
                            LastName = "Hồ Văn",
                            LastUpdateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9422),
                            LoginMethod = 1,
                            PhoneNumber = "0278569488",
                            RoleId = 1,
                            SaltPassword = new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 },
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            BirthDay = new DateTime(2000, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9451),
                            Email = "hungnhde160214@fpt.edu.vn",
                            FirstName = "Hùng",
                            FullName = "Hùng Nguyễn Huy",
                            Gender = true,
                            HashPassword = "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F",
                            Image = "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg",
                            IsEmailConfirmed = false,
                            LastName = "Nguyễn Huy",
                            LastUpdateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9452),
                            LoginMethod = 1,
                            PhoneNumber = "0163249576",
                            RoleId = 1,
                            SaltPassword = new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 },
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            BirthDay = new DateTime(2002, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9518),
                            Email = "trilmde160230@fpt.edu.vn",
                            FirstName = "Trí",
                            FullName = "Trí Lê Minh",
                            Gender = true,
                            HashPassword = "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F",
                            Image = "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg",
                            IsEmailConfirmed = false,
                            LastName = "Lê Minh",
                            LastUpdateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9519),
                            LoginMethod = 1,
                            PhoneNumber = "0245747692",
                            RoleId = 1,
                            SaltPassword = new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 },
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            BirthDay = new DateTime(2002, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9581),
                            Email = "quocndcde160171@fpt.edu.vn",
                            FirstName = "Quốc",
                            FullName = "Quốc Nguyễn Đăng Cường",
                            Gender = false,
                            HashPassword = "FB410C2474AFDF5B8FCF6B3C3BE115954315CAD7EA7870A39A1C708813A690F1B15B789570BF6918CCAFEF6812C211110783F65AA4289B1A8740D50841421D1F",
                            Image = "C:\\Capstone_Project\\CapstoneProject\\BackEnd\\FVenue\\BusinessObjectswwwroot/Image/Administrator/SuperAdmin.jpg",
                            IsEmailConfirmed = true,
                            LastName = "Nguyễn Đăng Cường",
                            LastUpdateDate = new DateTime(2024, 2, 26, 20, 16, 43, 379, DateTimeKind.Local).AddTicks(9582),
                            LoginMethod = 2,
                            PhoneNumber = "0458367938",
                            RoleId = 1,
                            SaltPassword = new byte[] { 104, 218, 233, 238, 19, 210, 66, 16, 187, 39, 222, 169, 82, 221, 39, 97, 220, 202, 120, 111, 95, 79, 43, 184, 118, 247, 45, 22, 131, 49, 56, 20, 225, 142, 60, 54, 213, 232, 67, 30, 245, 199, 49, 251, 184, 169, 57, 68, 49, 229, 156, 240, 118, 220, 37, 190, 138, 205, 29, 9, 206, 4, 72, 30 },
                            Status = false
>>>>>>> Stashed changes
                        });
                });

            modelBuilder.Entity("BusinessObjects.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BusinessObjects.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BusinessObjects.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BusinessObjects.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("BusinessObjects.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "VenueManager"
                        },
                        new
                        {
                            Id = 3,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("BusinessObjects.Models.Venue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeoLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("LowerPrice")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UpperPrice")
                        .HasColumnType("real");

                    b.Property<int>("WardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("WardId");

                    b.ToTable("Venues");
<<<<<<< Updated upstream
=======

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Đỉnh Bàn Cờ",
                            GeoLocation = "16.1203775657414,108.27607464602765",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipNTJk8DvgrCr2RyeTfKzedNpx4o4LOO06rSXSVQ=w408-h272-k-no",
                            LowerPrice = 0f,
                            Name = "Đỉnh Bàn Cờ",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "",
                            UpperPrice = 0f,
                            WardId = 41
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Cầu Rồng",
                            GeoLocation = "16.061233815354754,108.22749003748194",
                            Image = "https://static.vinwonders.com/2022/04/cau-rong-da-nang-1-1.jpg",
                            LowerPrice = 0f,
                            Name = "Cầu Rồng",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Nguyễn Văn Linh",
                            UpperPrice = 0f,
                            WardId = 10
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Cầu Sông Hàn",
                            GeoLocation = "16.072169332052994,108.22683626631773",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipPR0yFg71ydHaR3xXbbMApGnySOSmF5IBCXeWmc=w408-h306-k-no",
                            LowerPrice = 0f,
                            Name = "Cầu Sông Hàn",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Lê Duẩn",
                            UpperPrice = 0f,
                            WardId = 3
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Cầu Nguyễn Văn Trỗi",
                            GeoLocation = "16.05112083078253,108.22907016535224",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipNTJk8DvgrCr2RyeTfKzedNpx4o4LOO06rSXSVQ=w408-h272-k-no",
                            LowerPrice = 0f,
                            Name = "Cầu Nguyễn Văn Trỗi",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Nguyễn Văn Thoại",
                            UpperPrice = 0f,
                            WardId = 37
                        },
                        new
                        {
                            Id = 5,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Cầu Tình Yêu",
                            GeoLocation = "16.1203775657414,108.27607464602765",
                            Image = "https://ik.imagekit.io/tvlk/blog/2023/08/cau-tinh-yeu-da-nang-2.jpg?tr=dpr-2",
                            LowerPrice = 0f,
                            Name = "Cầu Tình Yêu",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Trần Hưng Đạo",
                            UpperPrice = 0f,
                            WardId = 37
                        },
                        new
                        {
                            Id = 6,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Chợ đêm Sơn Trà",
                            GeoLocation = "16.06160809465977,108.23198549515325",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipOy3zJV9uGKBOAvqq7JfD47k-pJ3pJdX08AsFqt=w493-h240-k-no",
                            LowerPrice = 0f,
                            Name = "Chợ đêm Sơn Trà",
                            OpenTime = new DateTime(2024, 2, 26, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Mai Hắc Đế",
                            UpperPrice = 0f,
                            WardId = 37
                        },
                        new
                        {
                            Id = 7,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Tượng Cá Chép hóa Rồng",
                            GeoLocation = "16.062920294590672,108.22982572398891",
                            Image = "https://lh3.googleusercontent.com/p/AF1QipOsja5mY4FutBBksUpPGk7xtTfT2LONbebEZsIY=s1360-w1360-h1020",
                            LowerPrice = 0f,
                            Name = "Tượng Cá Chép hóa Rồng",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Trần Hưng Đạo",
                            UpperPrice = 0f,
                            WardId = 37
                        },
                        new
                        {
                            Id = 8,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Biển Mỹ Khê",
                            GeoLocation = "16.05658360521848,108.24744872398874",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipPgpkvaWeKD9pejm2Org-oEx-SWXLyGH_qSUneu=w426-h240-k-no",
                            LowerPrice = 0f,
                            Name = "Biển Mỹ Khê",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Võ Nguyên Giáp",
                            UpperPrice = 0f,
                            WardId = 42
                        },
                        new
                        {
                            Id = 9,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Công viên 29/3",
                            GeoLocation = "16.1203775657414,108.27607464602765",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipNPIejeI79llYfMNFnAdGnaBKNCt6G4Fwo6Q2tM=w426-h240-k-no",
                            LowerPrice = 0f,
                            Name = "Công viên 29/3",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "23 Nguyễn Tri Phương",
                            UpperPrice = 0f,
                            WardId = 33
                        },
                        new
                        {
                            Id = 10,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Bãi tắm Phạm Văn Đồng",
                            GeoLocation = "16.07338349250206,108.24686918822724",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipMeJRsg8S_9w2m3KaBuovV_87uF5IsM8eubr1vY=w408-h272-k-no",
                            LowerPrice = 0f,
                            Name = "Bãi tắm Phạm Văn Đồng",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Võ Nguyên Giáp",
                            UpperPrice = 0f,
                            WardId = 37
                        },
                        new
                        {
                            Id = 11,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Bãi đá Obama",
                            GeoLocation = "16.09979446980971,108.30122137705182",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipNZY0gLKkyBp6SeM7KEMPadCos2lOCHNwWhAIvI=w408-h354-k-no",
                            LowerPrice = 0f,
                            Name = "Bãi đá Obama",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "",
                            UpperPrice = 0f,
                            WardId = 41
                        },
                        new
                        {
                            Id = 12,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Chân cầu Thuận Phước.",
                            GeoLocation = "16.095265292762104,108.22045666551136",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipP4U2h2NuO5IC4xNdkPtRO0hTpg-kRLkUo1RuYY=w408-h271-k-no",
                            LowerPrice = 0f,
                            Name = "Chân cầu Thuận Phước.",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "Lê Đức Thọ",
                            UpperPrice = 0f,
                            WardId = 39
                        },
                        new
                        {
                            Id = 13,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 22, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Chợ đêm Helio",
                            GeoLocation = "16.037429266613337,108.22457798825782",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipOT5qP5cG4MJAC6pFlFwbNhpTJRFBKDZi16uD79=w408-h306-k-no",
                            LowerPrice = 0f,
                            Name = "Chợ đêm Helio",
                            OpenTime = new DateTime(2024, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "2 Tháng 9",
                            UpperPrice = 0f,
                            WardId = 5
                        },
                        new
                        {
                            Id = 14,
                            AccountId = 1,
                            CloseTime = new DateTime(2024, 2, 26, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đây là mô tả về Rạn Nam Ô",
                            GeoLocation = "16.117981036882956,108.13000619993463",
                            Image = "https://lh5.googleusercontent.com/p/AF1QipPLWohOtxqRtG8sPz8yFNmPk7UA_QovxpBtwifr=w408-h305-k-no",
                            LowerPrice = 0f,
                            Name = "Rạn Nam Ô",
                            OpenTime = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Street = "",
                            UpperPrice = 0f,
                            WardId = 21
                        });
>>>>>>> Stashed changes
                });

            modelBuilder.Entity("BusinessObjects.Models.VenueSubCategory", b =>
                {
                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("VenueId", "SubCategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("VenueSubCategories");
                });

            modelBuilder.Entity("BusinessObjects.Models.Ward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("BusinessObjects.Models.Account", b =>
                {
                    b.HasOne("BusinessObjects.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessObjects.Models.City", b =>
                {
                    b.HasOne("BusinessObjects.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BusinessObjects.Models.District", b =>
                {
                    b.HasOne("BusinessObjects.Models.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BusinessObjects.Models.SubCategory", b =>
                {
                    b.HasOne("BusinessObjects.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BusinessObjects.Models.Venue", b =>
                {
                    b.HasOne("BusinessObjects.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.Ward", "Ward")
                        .WithMany()
                        .HasForeignKey("WardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Ward");
                });

            modelBuilder.Entity("BusinessObjects.Models.VenueSubCategory", b =>
                {
                    b.HasOne("BusinessObjects.Models.SubCategory", "SubCategory")
                        .WithMany("VenueSubCategories")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Models.Venue", "Venue")
                        .WithMany("VenueSubCategories")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("BusinessObjects.Models.Ward", b =>
                {
                    b.HasOne("BusinessObjects.Models.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("BusinessObjects.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("BusinessObjects.Models.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("BusinessObjects.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("BusinessObjects.Models.District", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("BusinessObjects.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("BusinessObjects.Models.SubCategory", b =>
                {
                    b.Navigation("VenueSubCategories");
                });

            modelBuilder.Entity("BusinessObjects.Models.Venue", b =>
                {
                    b.Navigation("VenueSubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
