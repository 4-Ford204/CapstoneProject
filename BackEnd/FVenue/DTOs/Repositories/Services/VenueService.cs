using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class VenueService : IVenueService
    {
        public List<Venue> GetVenues()
        {
            using (var _context = new DatabaseContext())
            {
                var venues = _context.Venues.Where(x => x.Status == true).ToList();
                return venues;
            }
        }

        public Venue GetVenue(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var venue = _context.Venues.Find(id);
                return venue;
            }
        }

        public List<Venue> GetVenuesBySubCategory(int subCategoryId)
        {
            using (var _context = new DatabaseContext())
            {
                var venues = _context.Venues.Join(_context.VenueSubCategories,
                    venue => venue.Id,
                    venueSubCategory => venueSubCategory.VenueId,
                    (venue, venueSubCategory) => new
                    {
                        Venue = venue,
                        VenueSubCategory = venueSubCategory
                    })
                    .Where(x => x.VenueSubCategory.SubCategoryId == subCategoryId)
                    .Select(x => x.Venue).ToList();
                return venues;
            }
        }
        public List<Venue> SearchVenueBySubCategoryName(string subCategoryName)
        {
            using (var _context = new DatabaseContext())
            {
                var venues = _context.Venues.Join(_context.VenueSubCategories,
                    venue => venue.Id,
                    venueSubCategory => venueSubCategory.VenueId,
                    (venue, venueSubCategory) => new
                    {
                        Venue = venue,
                        VenueSubCategory = venueSubCategory
                    })
                    .Join(_context.SubCategories,
                    vsc => vsc.VenueSubCategory.SubCategoryId,
                    sc => sc.Id,
                    (vsc, sc) => new
                    {
                        Venue = vsc.Venue,
                        SubCategory = sc
                    })
                    .Where(x => x.SubCategory.Name == subCategoryName)
                    .Select(x => x.Venue).ToList();
                return venues;
            }
        }

        public KeyValuePair<bool, string> InsertVenue(Venue venue)
        {
            try
            {
                string result = String.Empty;
                if (!ValidationService.VenueValidation(venue, out result))
                    return new KeyValuePair<bool, string>(false, result);

                using (var _context = new DatabaseContext())
                {
                    _context.Venues.Add(venue);
                    if (_context.SaveChanges() != 1)
                        throw new Exception("Save Changes Error");
                    else
                        return new KeyValuePair<bool, string>(true, result);
                }
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }

        public KeyValuePair<bool, string> UpdateVenue(Venue updateVenue)
        {
            try
            {
                string result = String.Empty;
                if (!ValidationService.VenueValidation(updateVenue, out result))
                    return new KeyValuePair<bool, string>(false, result);

                using (var _context = new DatabaseContext())
                {
                    var venue = _context.Venues.Find(updateVenue.Id);
                    if (venue == null)
                        throw new Exception("Venue Not Found");
                    _context.Venues.Update(updateVenue);
                    if (_context.SaveChanges() != 1)
                        throw new Exception("Save Changes Error");
                    else
                        return new KeyValuePair<bool, string>(true, string.Empty);
                }
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }

        public KeyValuePair<bool, string> DeleteVenue(int id)
        {
            try
            {
                using (var _context = new DatabaseContext())
                {
                    var venue = _context.Venues.Find(id);
                    if (venue == null)
                        throw new Exception("Venue Not Found");
                    else
                    {
                        venue.Status = false;
                        if (_context.SaveChanges() != 1)
                            throw new Exception("Save Changes Error");
                        else
                            return new KeyValuePair<bool, string>(false, String.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }
    }
}
