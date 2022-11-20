using AutoMapper;
using MyProject.Commen.DTOs;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;


namespace MyProject.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;


        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public RoleDTO Add(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Add(id, name, description));
        }

        public void Delete(int id)
        {
            _roleRepository.Delet(id);
        }

        public List<RoleDTO> GetAll()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepository.GetAll());
        }

        public RoleDTO GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.GetById(id));
        }

        public RoleDTO Update(RoleDTO claim)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Update(claim));
        }
    }
}
