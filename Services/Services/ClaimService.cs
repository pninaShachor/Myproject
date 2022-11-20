using AutoMapper;
using MyProject.Commen.DTOs;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ClaimService : IClaimService
    {
        
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;
        public ClaimService(IClaimRepository ClaimRepositpry, IMapper mapper)
        {
            _claimRepository = ClaimRepositpry;
            _mapper = mapper;
        }
        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicy policy)
        {
           return _mapper.Map<ClaimDTO>(_claimRepository.Add(id, roleId, permissionId, policy));
        }

        public void Delete(int id)
        {
            _claimRepository.Delet(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public ClaimDTO Update(ClaimDTO claim)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(claim));
        }
    }
}
