using AutoMapper;
using MyProject.Commen.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>()
                    .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Description))
                    .ReverseMap();
        }
    }
}
