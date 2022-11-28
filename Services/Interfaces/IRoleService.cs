using MyProject.Commen.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        public Task<List<RoleDTO>> GetAllAsync();

        public Task<RoleDTO> GetByIdAsync(int id);

        public Task<RoleDTO> AddAsync(int id, string name, string description);

        public Task<RoleDTO> UpdateAsync(RoleDTO role);

        public Task DeleteAsync(int id);
    }
}
