using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management.Data.Models.Violations;
using User.Management.Service.Models.ViolationDTOs;

namespace User.Management.Service.Services
{
    public interface IViolationService
    {
        Task<ViolationDtoResponse> AddViolationAsync(ViolationDtoRequest violation);
        Task<List<ViolationDtoResponse>> GetAllViolationsAsync();
    }
}
