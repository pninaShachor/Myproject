using MyProject.Commen.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        public List<RoleDTO> GetAll();

        public RoleDTO GetById(int id);

        public RoleDTO Add(int id, string name, string description);

        public RoleDTO Update(RoleDTO role);

        public void Delete(int id);
    }
}
