using AutoMapper;
using MyProject.Commen.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
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
        public async Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, Commen.DTOs.EPolicy policy)
        {
           return  _mapper.Map<ClaimDTO>(await _claimRepository.AddAsync(id, roleId, permissionId, (Repositories.Entities.EPolicy)policy));
        }

        public async Task DeleteAsync(int id)
        {
            await _claimRepository.DeleteAsync(id);
        }

        public async Task<List<ClaimDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ClaimDTO>>(await _claimRepository.GetAllAsync());
        }

        public async Task<ClaimDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.GetByIdAsync(id));
        }

        public async Task<ClaimDTO> UpdateAsync(ClaimDTO claim)
        {
            return _mapper.Map<ClaimDTO>(await _claimRepository.UpdateAsync(_mapper.Map<Claim>(claim)));
        }

    }
}
