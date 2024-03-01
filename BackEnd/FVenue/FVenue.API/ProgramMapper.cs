using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Account;
using DTOs.Models.Category;
using DTOs.Models.SubCategory;
using DTOs.Models.SubCategoryRequest;
using DTOs.Models.Venue;
using DTOs.Repositories.Interfaces;

namespace FVenue.API
{
    public class ProgramMapper : Profile
    {
        public ProgramMapper(IAccountService accountService, ICategoryService categoryService, ILocationService locationService)
        {
            #region Account

            CreateMap<Account, AccountDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => Common.FormatDateTime(src.CreateDate)))
                .ForMember(dest => dest.LastUpdateDate, opt => opt.MapFrom(src => Common.FormatDateTime(src.LastUpdateDate)))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => Common.GetRoleName(src.RoleId)))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.BirthDay, opt => opt.MapFrom(src => Common.FormatDateTime(src.BirthDay)))
                .ForMember(dest => dest.LoginMethod, opt => opt.MapFrom(src => src.LoginMethod))
                .ForMember(dest => dest.IsEmailConfirmed, opt => opt.MapFrom(src => src.IsEmailConfirmed));

            #endregion

            #region Category

            CreateMap<Category, CategoryDTO>();

            #endregion

            #region SubCategory

            CreateMap<SubCategory, SubCategoryDTO>();

            #endregion

            #region SubCategoryRequest

            CreateMap<SubCategoryRequest, SubCategoryRequestDTO>()
                .ForMember(dest => dest.RequestUserName, opt => opt.MapFrom(src => accountService.GetAccountName(src.RequestUserId)))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => categoryService.GetCategoryName(src.CategoryId)))
                .ForMember(dest => dest.Badge, opt => opt.MapFrom(src => Common.SetBadgeBaseOnCreateDate(src.CreateDate)));

            #endregion

            #region Venue

            CreateMap<Venue, VenueDTO>()
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => locationService.GetLocation(src.WardId)))
                .ForMember(dest => dest.GeoLocation, opt => opt.MapFrom(src => Common.FormatGeoLocation(src.GeoLocation)))
                .ForMember(dest => dest.OpenTime, opt => opt.MapFrom(src => Common.ConvertDateTimeToTimeOnly(src.OpenTime)))
                .ForMember(dest => dest.CloseTime, opt => opt.MapFrom(src => Common.ConvertDateTimeToTimeOnly(src.CloseTime)))
                .ForMember(dest => dest.AccountName, opt => opt.MapFrom(src => accountService.GetAccountName(src.AccountId)));
            CreateMap<VenueInsertDTO, Venue>()
                .ForMember(dest => dest.OpenTime, opt => opt.MapFrom(src => Common.ConvertTimeOnlyToDateTime(src.OpenTime)))
                .ForMember(dest => dest.CloseTime, opt => opt.MapFrom(src => Common.ConvertTimeOnlyToDateTime(src.CloseTime)));
            CreateMap<VenueUpdateDTO, Venue>()
                .ForMember(dest => dest.OpenTime, opt => opt.MapFrom(src => Common.ConvertTimeOnlyToDateTime(src.OpenTime)))
                .ForMember(dest => dest.CloseTime, opt => opt.MapFrom(src => Common.ConvertTimeOnlyToDateTime(src.CloseTime)));

            #endregion
        }
    }
}
