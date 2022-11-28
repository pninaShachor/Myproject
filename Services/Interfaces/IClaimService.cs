using MyProject.Commen.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        public Task<List<ClaimDTO>> GetAllAsync();

        public Task<ClaimDTO> GetByIdAsync(int id);

        public Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicy policy);

        public Task<ClaimDTO> UpdateAsync(ClaimDTO claim);

        public Task DeleteAsync(int id);
    }
}
