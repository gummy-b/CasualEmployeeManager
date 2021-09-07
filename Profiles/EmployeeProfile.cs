using AutoMapper;
using CasualEmployee.API.DTOs.Employees;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeCreateDTO, CEmployee>();
            CreateMap<UpdateEmployeeDTO, CEmployee>();
            CreateMap<CEmployee, EmployeeCreateDTO>();
        }
    }
}