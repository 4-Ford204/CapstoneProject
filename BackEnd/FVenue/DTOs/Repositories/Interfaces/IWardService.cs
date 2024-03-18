using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Repositories.Interfaces
{
    public interface IWardService
    {
        Task<List<Ward>> GetListWards();
    }
}
