using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface IValidationService
    {
        #region Venue
        public bool VenueValidation(bool modelState, Venue venue, out string result);
        #endregion
    }
}
