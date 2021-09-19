using AutoMapper;
using CasualEmployee.API.Models;
using CasualEmployee.API.DTOs.Hours;

namespace CasualEmployee.API.Profiles
{
    public class HoursWorkedProfile : Profile
    {
        public HoursWorkedProfile()
        {
            CreateMap<Hours_Worked, CapturedHrsReadDTO>();
            CreateMap<CapturedHrsCreateDTO, Hours_Worked>();
            CreateMap<CapturedHrsUpdateDTO, Hours_Worked>();
        }
    }
}