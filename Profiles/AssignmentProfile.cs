using AutoMapper;
using CasualEmployee.API.DTOs.Assignemnts;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Profiles
{
    public class AssignmentProfile : Profile
    {
        public AssignmentProfile()
        {
            CreateMap<Assign_Task, AssignmentReadDTO>();
            CreateMap<AssignmentCreateDTO, Assign_Task>();
            CreateMap<AssignmentUpdateDTO, Assign_Task>();
        }
    }
}