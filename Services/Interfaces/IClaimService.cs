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
        public List<ClaimDTO> GetAll();

        public ClaimDTO GetById(int id);

        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicy policy);

        public ClaimDTO Update(ClaimDTO claim);

        public void Delete(int id);
    }
}
