using BusinessObjects;
using BusinessObjects.Models;

namespace DTOs
{
    public static class ValidationService
    {
        #region Venue

        public static bool VenueValidation(Venue venue, out string result)
        {
            if (venue == null)
            {
                result = "Venue Not Found";
                return false;
            }
            using (var _context = new DatabaseContext())
            {
                if (_context.Wards.Find(venue.WardId) == null)
                {
                    result = "Not Valid Location (Ward)";
                    return false;
                }
                result = "Valid Venue";
                return true;
            }
        }

        #endregion
    }
}