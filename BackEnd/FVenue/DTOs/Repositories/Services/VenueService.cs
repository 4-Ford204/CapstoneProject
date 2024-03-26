using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Venue;
using DTOs.Repositories.Interfaces;
using System.Collections.Concurrent;

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

        public List<Venue> SearchVenue(VenueSearchDTO venueSearchDTO)
        {
            var searchVenueIds = new ConcurrentBag<List<int>>();
            var searchTasks = new List<Task>();
            if (venueSearchDTO.LowerPrice.HasValue)
                searchTasks.Add(Task.Run(() =>
                {
                    using (var _context = new DatabaseContext())
                    {
                        var venueIds = _context.Venues.Where(x => x.LowerPrice >= venueSearchDTO.LowerPrice).Select(x => x.Id).ToList();
                        searchVenueIds.Add(venueIds);
                    }
                }));
            if (venueSearchDTO.UpperPrice.HasValue)
                searchTasks.Add(Task.Run(() =>
                {
                    using (var _context = new DatabaseContext())
                    {
                        var venueIds = _context.Venues.Where(x => x.UpperPrice <= venueSearchDTO.UpperPrice).Select(x => x.Id).ToList();
                        searchVenueIds.Add(venueIds);
                    }
                }));
            Task.WaitAll(searchTasks.ToArray());
            var searchResult = searchVenueIds.ToArray();
            var venueIds = searchResult.Count() == 0 ? new List<int>() : searchResult[0];
            for (int i = 1; i < searchResult.Count(); i++)
                venueIds = venueIds.Union(searchResult[i]).ToList();
            using (var _context = new DatabaseContext())
            {
                var venues = _context.Venues.Where(x => venueIds.Contains(x.Id)).ToList();
                return venues;
            }
        }
    }
}
