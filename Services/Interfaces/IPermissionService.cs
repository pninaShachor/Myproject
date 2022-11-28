using MyProject.Commen.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermissionService
    {
        public Task<List<PermissionDTO>> GetAllAsync();

        public Task<PermissionDTO> GetByIdAsync(int id);

        public Task<PermissionDTO> AddAsync(int id, string name, string description);

        public Task<PermissionDTO> UpdateAsync(PermissionDTO permission);

        public Task DeleteAsync(int id);
    }
}
