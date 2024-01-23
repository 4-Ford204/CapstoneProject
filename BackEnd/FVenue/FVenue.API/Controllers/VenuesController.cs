using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Venue;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    public class VenuesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public VenuesController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region View

        public IActionResult Index() => View();

        [HttpGet, Route("Venues/InsertVenuePopup")]
        public PartialViewResult InsertVenuePopup()
            => PartialView("_VenuePartial");

        #endregion

        #region Data

        [HttpGet, Route("Venues/GetVenueDTOs")]
        public List<VenueDTO> GetVenueDTOs()
            => _mapper.Map<List<Venue>, List<VenueDTO>>(_context.Venues.ToList());

        [HttpPut, Route("Venues/ChangeVenueStatus")]
        public string ChangeVenueStatus(int[] ids)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var id in ids)
                    {
                        var venue = _context.Venues.FirstOrDefault(x => x.Id == id);
                        if (venue == null)
                            throw new Exception($"{id} không tồn tại");
                        venue.Status = !venue.Status;
                        _context.Entry(venue).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        if (_context.SaveChanges() != 1)
                            throw new Exception("Save Changes Error");
                    }
                    transaction.Commit();
                    return $"Đã đổi trạng thái của các địa điểm [{String.Join(",", ids)}]";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return ex.Message;
                }
            }
        }


        #endregion
    }
}
