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
        public List<PermissionDTO> GetAll();

        public PermissionDTO GetById(int id);

        public PermissionDTO Add(int id, string name, string description);

        public PermissionDTO Update(PermissionDTO permission);

        public void Delete(int id);
    }
}
