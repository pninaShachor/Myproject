using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context;
        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Permission> AddAsync(int id, string name, string description)
        {
            var r = _context.Permissions.Add(new Permission { Id = id, Name = name, Description = description });
            await _context.SaveChangesAsync();
            return r.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Permissions.Remove(_context.Permissions.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Permission>> GetAllAsync()
        {
            return await _context.Permissions.ToListAsync();
        }

        public async Task<Permission> GetByIdAsync(int id)
        {
            return await _context.Permissions.FindAsync(id);
        }

        public async Task<Permission> UpdateAsync(Permission role)
        {
            var r1 = _context.Permissions.Find(role.Id);
            r1.Name = role.Name;
            r1.Description = role.Description;
            await _context.SaveChangesAsync();
            return r1;
        }
    }
}
