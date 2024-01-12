using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Category;
using DTOs.Models.Venue;
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
                .ForMember(dest => dest.GeoLocation, opt => opt.MapFrom(src => Common.FormatGeoLocation(src.GeoLocation)))
                .ForMember(dest => dest.OpenTime, opt => opt.MapFrom(src => Common.ConvertDateTimeToTimeOnly(src.OpenTime)))
                .ForMember(dest => dest.CloseTime, opt => opt.MapFrom(src => Common.ConvertDateTimeToTimeOnly(src.CloseTime)));
            CreateMap<VenueInsertDTO, Venue>()
                .ForMember(dest => dest.OpenTime, opt => opt.MapFrom(src => Common.ConvertTimeOnlyToDateTime(src.OpenTime)))
                .ForMember(dest => dest.CloseTime, opt => opt.MapFrom(src => Common.ConvertTimeOnlyToDateTime(src.CloseTime)));
            CreateMap<VenueUpdateDTO, Venue>().IncludeBase<VenueInsertDTO, Venue>();

            #endregion

            #region Category

            CreateMap<Category, CategoryDTO>();

            #endregion
        }
    }
}
