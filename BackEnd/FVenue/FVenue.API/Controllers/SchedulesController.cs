using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Schedule;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [AdministratorAuthentication]
    public class SchedulesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public SchedulesController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region View

        public IActionResult Index() => View();

        #endregion

        #region Data

        public List<ScheduleDTO> GetScheduleDTOs()
            => _mapper.Map<List<Schedule>, List<ScheduleDTO>>(_context.Schedules.ToList());

        #endregion
    }
}
