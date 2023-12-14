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
        public DbSet<User> Users { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<VenueManager> VenueManagers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configuration = builder.Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("FVenue"));
                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("FVenueTAB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(GetRoles());
            modelBuilder.Entity<Venue>().HasData(GetVenues());
            modelBuilder.Entity<VenueManager>().HasData(GetVenueManagers());
            modelBuilder.Entity<Country>().HasData(GetCountries());
            modelBuilder.Entity<City>().HasData(GetCities());
            modelBuilder.Entity<District>().HasData(GetDistricts());
            modelBuilder.Entity<Ward>().HasData(GetWards());
        }

        #region Get Seeding Data

        private List<Role> GetRoles()
            => new List<Role> {
                new Role { Id = 1, Name = "Administrator" },
                new Role { Id = 2, Name = "Venue Manager"},
                new Role { Id = 3, Name = "User" }
            };
        private List<VenueManager> GetVenueManagers()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/SeedingData/Venue.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<VenueManager> venueManagers = new List<VenueManager>();
                        string venueManager;
                        byte[] salt;
                        string hashPassword = Common.HashPassword("fvenue@123", out salt);
                        while ((venueManager = streamReader.ReadLine()) != null)
                        {
                            string[] venueManagerField = venueManager.Split(',');
                            venueManagers.Add(new VenueManager
                            {
                                Id = int.Parse(venueManagerField[0].Trim()),
                                Email = $"manager{venueManagerField[0].Trim()}@gmail.com",
                                SaltPassword = salt,
                                HashPassword = hashPassword,
                                PhoneNumber = null,
                                CreatDate = DateTime.Now,
                                LastUpdateDate = DateTime.Now,
                                Status = true,
                                RoleId = 2,
                                IsAuthenticated = -1,
                                Name = venueManagerField[1].Trim() + " Manager",
                                VenueId = int.Parse(venueManagerField[0].Trim())
                            });
                        }
                        return venueManagers;
                    };
                };
            }
            catch
            {
                return new List<VenueManager>();
            }
        }
        private List<Venue> GetVenues()
        {
            try
            {
                using (FileStream fileStream = new FileStream("Data/Venue.txt", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        List<Venue> venues = new List<Venue>();
                        string venue;
                        while ((venue = streamReader.ReadLine()) != null)
                        {
                            string[] venueField = venue.Split(',');
                            venues.Add(new Venue
                            {
                                Id = int.Parse(venueField[0].Trim()),
                                Name = venueField[1].Trim(),
                                Image = venueField[2].Trim(),
                                Street = venueField[3].Trim(),
                                WardId = int.Parse(venueField[4].Trim()),
                                GeoLocation = venueField[5].Trim() + "," + venueField[6].Trim(),
                                OpenTime = Common.ConvertTimeOnlyToDateTime(venueField[7].Trim()),
                                CloseTime = Common.ConvertTimeOnlyToDateTime(venueField[8].Trim()),
                                LowerPrice = float.Parse(venueField[9].Trim()),
                                UpperPrice = float.Parse(venueField[10].Trim()),
                                Status = venueField[11].Trim().ToLower().Equals("true") ? true : false
                            });
                        }
                        return venues;
                    };
                };
            }
            catch
            {
                return new List<Venue>();
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

        #endregion
    }
}
