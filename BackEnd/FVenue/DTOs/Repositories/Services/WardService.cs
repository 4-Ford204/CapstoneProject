using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DTOs.Repositories.Services
{
    public class WardService : IWardService
    {
        public async Task<List<Ward>> GetListWards()
        {
            using (var _context = new DatabaseContext())
            {
                return await _context.Wards.ToListAsync();
            }
        }
    }
}
