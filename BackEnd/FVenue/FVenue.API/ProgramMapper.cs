using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models;
using DTOs.Repositories.Interfaces;

namespace FVenue.API
{
    public class ProgramMapper : Profile
    {
        public ProgramMapper(ILocationService locationService)
        {
            #region Venue

            CreateMap<Venue, VenueDTO>()
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => locationService.GetLocation(src.WardId)))
                .ForMember(dest => dest.OpenTime, opt => opt.MapFrom(src => Common.ConvertDateTimeToTimeOnly(src.OpenTime)))
                .ForMember(dest => dest.CloseTime, opt => opt.MapFrom(src => Common.ConvertDateTimeToTimeOnly(src.CloseTime)));

            #endregion
        }
    }
}
