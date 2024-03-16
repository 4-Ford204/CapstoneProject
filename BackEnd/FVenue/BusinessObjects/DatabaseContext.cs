using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubCategoryRequest> SubCategoryRequests { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<VenueSubCategory> VenueSubCategories { get; set; }
        public DbSet<VNPAYPayment> VNPAYPayments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.EnableSensitiveDataLogging();

                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configuration = builder.Build();

                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("FVenue"));
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("FVenueDemo"));
                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("FVenueTAB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(GetRoles());
            modelBuilder.Entity<Account>().HasData(GetAccounts(out int defaultAccountNumber));
            modelBuilder.Entity<Country>().HasData(GetCountries());
            modelBuilder.Entity<City>().HasData(GetCities());
            modelBuilder.Entity<District>().HasData(GetDistricts());
            modelBuilder.Entity<Ward>().HasData(GetWards());
            modelBuilder.Entity<Category>().HasData(GetCategories());
            modelBuilder.Entity<SubCategory>().HasData(GetSubCategories());
            modelBuilder.Entity<SubCategoryRequest>().HasData(GetSubCategoryRequests());
            modelBuilder.Entity<Venue>().HasData(GetVenues(ref defaultAccountNumber, out int defaultVenueNumber));
            modelBuilder.Entity<VenueSubCategory>().HasData(GetVenueSubCategories(ref defaultVenueNumber));
        }

        #region Get Seeding Data

        private List<Role> GetRoles()
            => new List<Role> {
                new Role { Id = 1, Name = "Administrator" },
                new Role { Id = 2, Name = "VenueManager"},
                new Role { Id = 3, Name = "User" }
            };
        private List<Account> GetAccounts(out int defaultAccountNumber)
        {
            defaultAccountNumber = 0;
            try
            {
                byte[] salt;
                string hashPassword = Common.HashPassword("fvenue@123", out salt);
                List<Account> accounts = new List<Account>()
                {
                    new Account
                    {
                        Id = 1,
                        Email = "huynhduy20042002@gmail.com",
                        SaltPassword = salt,
                        HashPassword = hashPassword,
                        Image = Environment.CurrentDirectory + "wwwroot/Image/Administrator/SuperAdmin.jpg",
                        PhoneNumber = Common.RandomPhoneNumber(),
                        CreateDate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        Status = true,
                        RoleId = (int)EnumModel.Role.Administrator,
                        FirstName = "Duy",
                        LastName = "Lê Tự Huỳnh",
                        FullName = "Duy Lê Tự Huỳnh",
                        Gender = true,
                        BirthDay = new DateTime(2002, 04, 20),
                        LoginMethod = (int)EnumModel.LoginMethod.Email,
                        IsEmailConfirmed = false
                    },
                    new Account
                    {
                        Id = 2,
                        Email = "phuchvde160270@fpt.edu.vn",
                        SaltPassword = salt,
                        HashPassword = hashPassword,
                        Image = Environment.CurrentDirectory + "wwwroot/Image/Administrator/SuperAdmin.jpg",
                        PhoneNumber = Common.RandomPhoneNumber(),
                        CreateDate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        Status = true,
                        RoleId = (int)EnumModel.Role.Administrator,
                        FirstName = "Phúc",
                        LastName = "Hồ Văn",
                        FullName = "Phúc Hồ Văn",
                        Gender = true,
                        BirthDay = new DateTime(2002, 01, 31),
                        LoginMethod = (int)EnumModel.LoginMethod.Email,
                        IsEmailConfirmed = false
                    },
                    new Account
                    {
                        Id = 3,
                        Email = "hungnhde160214@fpt.edu.vn",
                        SaltPassword = salt,
                        HashPassword = hashPassword,
                        Image = Environment.CurrentDirectory + "wwwroot/Image/Administrator/SuperAdmin.jpg",
                        PhoneNumber = Common.RandomPhoneNumber(),
                        CreateDate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        Status = true,
                        RoleId = (int)EnumModel.Role.Administrator,
                        FirstName = "Hùng",
                        LastName = "Nguyễn Huy",
                        FullName = "Hùng Nguyễn Huy",
                        Gender = true,
                        BirthDay = new DateTime(2000, 11, 21),
                        LoginMethod = (int)EnumModel.LoginMethod.Email,
                        IsEmailConfirmed = false
                    },
                    new Account
                    {
                        Id = 4,
                        Email = "trilmde160230@fpt.edu.vn",
                        SaltPassword = salt,
                        HashPassword = hashPassword,
                        Image = Environment.CurrentDirectory + "wwwroot/Image/Administrator/SuperAdmin.jpg",
                        PhoneNumber = Common.RandomPhoneNumber(),
                        CreateDate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        Status = true,
                        RoleId = (int)EnumModel.Role.Administrator,
                        FirstName = "Trí",
                        LastName = "Lê Minh",
                        FullName = "Trí Lê Minh",
                        Gender = true,
                        BirthDay = new DateTime(2002, 10, 19),
                        LoginMethod = (int)EnumModel.LoginMethod.Email,
                        IsEmailConfirmed = false
                    },
                    new Account
                    {
                        Id = 5,
                        Email = "quocndcde160171@fpt.edu.vn",
                        SaltPassword = salt,
                        HashPassword = hashPassword,
                        Image = Environment.CurrentDirectory + "wwwroot/Image/Administrator/SuperAdmin.jpg",
                        PhoneNumber = Common.RandomPhoneNumber(),
                        CreateDate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        Status = false,
                        RoleId = (int)EnumModel.Role.Administrator,
                        FirstName = "Quốc",
                        LastName = "Nguyễn Đăng Cường",
                        FullName = "Quốc Nguyễn Đăng Cường",
                        Gender = false,
                        BirthDay = new DateTime(2002, 04, 23),
                        LoginMethod = (int)EnumModel.LoginMethod.Google,
                        IsEmailConfirmed = true
                    }
                };
                //using (FileStream fileStream = new FileStream("Data/Venue.txt", FileMode.Open))
                //{
                //    using (StreamReader streamReader = new StreamReader(fileStream))
                //    {
                //        defaultAccountNumber = accounts.Count;
                //        string account;
                //        while ((account = streamReader.ReadLine()) != null)
                //        {
                //            string[] accountField = account.Split(',');
                //            accounts.Add(new Account
                //            {
                //                Id = int.Parse(accountField[0].Trim()) + defaultAccountNumber,
                //                Email = $"manager{int.Parse(accountField[0].Trim())}@gmail.com",
                //                SaltPassword = salt,
                //                HashPassword = hashPassword,
                //                Image = "",
                //                PhoneNumber = Common.RandomPhoneNumber(),
                //                CreateDate = DateTime.Now,
                //                LastUpdateDate = DateTime.Now,
                //                Status = true,
                //                RoleId = 2,
                //                FirstName = accountField[1].Trim(),
                //                LastName = "Quản Lý"
                //            });
                //        }
                //    };
                //};
                return accounts;
            }
            catch
            {
                return new List<Account>();
            }
        }
        private List<Country> GetCountries()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/Country.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<Country> countries = new List<Country>();
                        string country;
                        while ((country = streamReader.ReadLine()) != null)
                        {
                            string[] countryField = country.Split(',');
                            countries.Add(new Country
                            {
                                Id = int.Parse(countryField[0].Trim()),
                                Name = countryField[1].Trim()
                            });
                        }
                        return countries;
                    };
                };
            }
            catch
            {
                return new List<Country>();
            }
        }
        private List<City> GetCities()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/City.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<City> cities = new List<City>();
                        string city;
                        while ((city = streamReader.ReadLine()) != null)
                        {
                            string[] cityField = city.Split(',');
                            cities.Add(new City
                            {
                                Id = int.Parse(cityField[0].Trim()),
                                Name = cityField[1].Trim(),
                                CountryId = int.Parse(cityField[2].Trim())
                            });
                        }
                        return cities;
                    };
                };
            }
            catch
            {
                return new List<City>();
            }
        }
        private List<District> GetDistricts()
        {

            try
            {
                using (FileStream fileStream = new FileStream("Data/District.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<District> districts = new List<District>();
                        string district;
                        while ((district = streamReader.ReadLine()) != null)
                        {
                            string[] districtField = district.Split(',');
                            districts.Add(new District
                            {
                                Id = int.Parse(districtField[0].Trim()),
                                Name = districtField[1].Trim(),
                                CityId = int.Parse(districtField[2].Trim())
                            });
                        }
                        return districts;
                    };
                };
            }
            catch
            {
                return new List<District>();
            }
        }
        private List<Ward> GetWards()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/Ward.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<Ward> wards = new List<Ward>();
                        string ward;
                        while ((ward = streamReader.ReadLine()) != null)
                        {
                            string[] wardField = ward.Split(',');
                            wards.Add(new Ward
                            {
                                Id = int.Parse(wardField[0].Trim()),
                                Name = wardField[1].Trim(),
                                DistrictId = int.Parse(wardField[2].Trim())
                            });
                        }
                        return wards;
                    };
                };
            }
            catch
            {
                return new List<Ward>();
            }
        }
        private List<Category> GetCategories()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/Category.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<Category> categories = new List<Category>();
                        string category;
                        while ((category = streamReader.ReadLine()) != null)
                        {
                            string[] categoryField = category.Split(',');
                            categories.Add(new Category
                            {
                                Id = int.Parse(categoryField[0].Trim()),
                                Name = categoryField[1].Trim()
                            });
                        }
                        return categories;
                    };
                };
            }
            catch
            {
                return new List<Category>();
            }
        }
        private List<SubCategory> GetSubCategories()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/SubCategory.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<SubCategory> subCategories = new List<SubCategory>();
                        string subCategory;
                        while ((subCategory = streamReader.ReadLine()) != null)
                        {
                            string[] subCategoryField = subCategory.Split(',');
                            subCategories.Add(new SubCategory
                            {
                                Id = int.Parse(subCategoryField[0].Trim()),
                                Name = subCategoryField[1].Trim(),
                                CategoryId = int.Parse(subCategoryField[2].Trim()),
                                CreateDate = DateTime.Now,
                                LastUpdateDate = DateTime.Now,
                                Status = true
                            });
                        }
                        return subCategories;
                    };
                };
            }
            catch
            {
                return new List<SubCategory>();
            }
        }
        private List<SubCategoryRequest> GetSubCategoryRequests()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/SubCategoryRequest.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<SubCategoryRequest> subCategoryRequests = new List<SubCategoryRequest>();
                        string subCategoryRequest;
                        while ((subCategoryRequest = streamReader.ReadLine()) != null)
                        {
                            string[] subCategoryRequestField = subCategoryRequest.Split(',');
                            subCategoryRequests.Add(new SubCategoryRequest
                            {
                                Id = int.Parse(subCategoryRequestField[0].Trim()),
                                Name = subCategoryRequestField[1].Trim(),
                                RequestUserId = int.Parse(subCategoryRequestField[2].Trim()),
                                CategoryId = int.Parse(subCategoryRequestField[3].Trim()),
                                AdministratorId = int.Parse(subCategoryRequestField[4].Trim()),
                                CreateDate = DateTime.Now.Subtract(TimeSpan.FromMinutes(int.Parse(subCategoryRequestField[5].Trim()))),
                                LastUpdateDate = DateTime.Now.Subtract(TimeSpan.FromMinutes(int.Parse(subCategoryRequestField[5].Trim()))),
                                Status = int.Parse(subCategoryRequestField[6].Trim())
                            });
                        };
                        return subCategoryRequests;
                    };
                };
            }
            catch
            {
                return new List<SubCategoryRequest>();
            }
        }
        private List<Venue> GetVenues(ref int defaultAccountNumber, out int defaultVenueNumber)
        {
            defaultVenueNumber = 0;
            try
            {
                List<Venue> venues = new List<Venue>();
                using (FileStream fileStream = new FileStream("Data/PublicVenue.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string venue;
                        while ((venue = streamReader.ReadLine()) != null)
                        {
                            string[] venueField = venue.Split(',');
                            venues.Add(new Venue
                            {
                                Id = int.Parse(venueField[0].Trim()),
                                Name = venueField[1].Trim(),
                                Image = venueField[2].Trim(),
                                Description = $"Đây là mô tả về {venueField[1].Trim()}",
                                Street = venueField[3].Trim(),
                                WardId = int.Parse(venueField[4].Trim()),
                                GeoLocation = venueField[5].Trim() + "," + venueField[6].Trim(),
                                OpenTime = Common.ConvertTimeOnlyToDateTime(venueField[7].Trim()),
                                CloseTime = Common.ConvertTimeOnlyToDateTime(venueField[8].Trim()),
                                LowerPrice = float.Parse(venueField[9].Trim()),
                                UpperPrice = float.Parse(venueField[10].Trim()),
                                Status = venueField[11].Trim().ToLower().Equals("true") ? true : false,
                                AccountId = int.Parse(venueField[12].Trim())
                            });
                        }
                        defaultVenueNumber = venues.Count;
                    };
                };
                //using (FileStream fileStream = new FileStream("Data/Venue.txt", FileMode.Open))
                //{
                //    using (StreamReader streamReader = new StreamReader(fileStream))
                //    {
                //        string venue;
                //        while ((venue = streamReader.ReadLine()) != null)
                //        {
                //            string[] venueField = venue.Split(',');
                //            venues.Add(new Venue
                //            {
                //                Id = int.Parse(venueField[0].Trim()) + defaultVenueNumber
                //                Name = venueField[1].Trim(),
                //                Image = venueField[2].Trim(),
                //                Description = $"Đây là mô tả về {venueField[1].Trim()}",
                //                Street = venueField[3].Trim(),
                //                WardId = int.Parse(venueField[4].Trim()),
                //                GeoLocation = venueField[5].Trim() + "," + venueField[6].Trim(),
                //                OpenTime = Common.ConvertTimeOnlyToDateTime(venueField[7].Trim()),
                //                CloseTime = Common.ConvertTimeOnlyToDateTime(venueField[8].Trim()),
                //                LowerPrice = float.Parse(venueField[9].Trim()),
                //                UpperPrice = float.Parse(venueField[10].Trim()),
                //                Status = venueField[11].Trim().ToLower().Equals("true") ? true : false,
                //                AccountId = int.Parse(venueField[0].Trim()) + defaultAccountNumber
                //            });
                //        }
                //    };
                //};
                return venues;
            }
            catch
            {
                return new List<Venue>();
            }
        }
        private List<VenueSubCategory> GetVenueSubCategories(ref int defaultVenueNumber)
        {
            try
            {
                List<VenueSubCategory> venueSubCategories = new List<VenueSubCategory>();
                using (FileStream fileStream = new FileStream("Data/PublicVenue.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string venueSubCategory;
                        while ((venueSubCategory = streamReader.ReadLine()) != null)
                        {
                            string[] venueSubCategoryField = venueSubCategory.Split(',');
                            venueSubCategories.Add(new VenueSubCategory
                            {
                                VenueId = int.Parse(venueSubCategoryField[0].Trim()),
                                SubCategoryId = int.Parse(venueSubCategoryField[13].Trim()),
                                CreateDate = DateTime.Now,
                                LastUpdateDate = DateTime.Now,
                                Status = true
                            });
                        }
                    };
                };
                //using (FileStream fileStream = new FileStream("Data/VenueSubCategory.txt", FileMode.Open))
                //{
                //    using (StreamReader streamReader = new StreamReader(fileStream))
                //    {
                //        string venueCategory;
                //        while ((venueCategory = streamReader.ReadLine()) != null)
                //        {
                //            string[] venueCategoryField = venueCategory.Split(',');
                //            venueCategories.Add(new VenueSubCategory
                //            {
                //                VenueId = int.Parse(venueCategoryField[0].Trim()),
                //                SubCategoryId = int.Parse(venueCategoryField[1].Trim())
                //            });
                //        }
                //    };
                //};
                return venueSubCategories;
            }
            catch
            {
                return new List<VenueSubCategory>();
            }
        }

        #endregion
    }
}
