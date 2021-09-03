using AutoMapper;
using CasualEmployee.API.DTOs.Persons;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonReadDTO>();
            CreateMap<PersonCreateDTO, Person>();
            CreateMap<UpdatePersonDTO, Person>();
        }
    }
}