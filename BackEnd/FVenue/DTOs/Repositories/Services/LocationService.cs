using BusinessObjects;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class LocationService : ILocationService
    {
        public string GetLocation(int wardId)
        {
            using (var _context = new DatabaseContext())
            {
                var result = _context.Countries
                    .Join(_context.Cities, country => country.Id, city => city.CountryId, (country, city) => new
                    {
                        CountryName = country.Name,
                        CityId = city.Id,
                        CityName = city.Name

                    }).Join(_context.Districts, city => city.CityId, district => district.CityId, (city, district) => new
                    {
                        city.CountryName,
                        city.CityName,
                        DistrictId = district.Id,
                        DistrictName = district.Name

                    }).Join(_context.Wards, district => district.DistrictId, ward => ward.DistrictId, (district, ward) => new
                    {
                        district.CountryName,
                        district.CityName,
                        district.DistrictName,
                        WardId = ward.Id,
                        WardName = ward.Name
                    }).Where(x => x.WardId == wardId).FirstOrDefault();

                return $"{result.WardName}, {result.DistrictName}, {result.CityName}, {result.CountryName}";
            }
        }
    }
}
