using BusinessObjects.Models;
using DTOs.Models.Venue;

namespace DTOs.Repositories.Interfaces
{
    public interface IVenueService
    {
        List<Venue> GetVenues();
        Venue GetVenue(int id);
        List<Venue> GetVenuesBySubCategory(int subCategoryId);
        List<Venue> SearchVenueBySubCategoryName(string subCategoryName);
        KeyValuePair<bool, string> InsertVenue(Venue venue);
        KeyValuePair<bool, string> UpdateVenue(Venue venue);
        KeyValuePair<bool, string> DeleteVenue(int id);
        List<Venue> SearchVenue(VenueSearchDTO venueSearchDTO);
    }
}
