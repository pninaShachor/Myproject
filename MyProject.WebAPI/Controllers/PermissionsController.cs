using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {

        private readonly IPermissionRepository _permissionRepository;

        public PermissionsController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        [HttpGet]
        public async Task<List<Permission>> Get()
        {
            return await  _permissionRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Permission> Get(int id)
        {
            return await  _permissionRepository.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await  _permissionRepository.DeleteAsync(id);
        }
        [HttpPut]

        public async Task Put([FromBody] Permission role)
        {
            await  _permissionRepository.UpdateAsync(role);
        }
    }
}
