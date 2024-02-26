using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface IVenueService
    {
        List<Venue> GetVenues();
        Venue GetVenue(int id);
        KeyValuePair<bool, string> InsertVenue(Venue venue);
        KeyValuePair<bool, string> UpdateVenue(Venue venue);
        KeyValuePair<bool, string> DeleteVenue(int id);
    }
}
