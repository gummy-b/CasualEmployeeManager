using AutoMapper;
using CasualEmployee.API.DTOs.Roles;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Profiles
{
    public class RolesProfile : Profile
    {
        public RolesProfile()
        {
            CreateMap<Roles, RolesReadDTO>();
            CreateMap<RolesCreateDTO, Roles>();
            CreateMap<UpdateRoleDTO, Roles>();
        }
    }
}
