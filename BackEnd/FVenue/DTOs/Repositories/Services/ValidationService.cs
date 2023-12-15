using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class ValidationService : IValidationService
    {
        #region Venue

        public bool VenueValidation(bool modelState, Venue venue, out string result)
        {
            if (venue == null)
            {
                result = "Venue Not Found";
                return false;
            }
            if (!modelState)
            {
                result = "Model State Is Invalid";
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