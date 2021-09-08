using AutoMapper;
using CasualEmployee.API.DTOs.Employees.Tasks;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Profiles
{
    public class TasksProfile : Profile
    {
        public TasksProfile()
        {
            CreateMap<Employee_Task, TaskReadDTO>();
            CreateMap<CreateTaskDTO, Employee_Task>();
            CreateMap<UpdateTaskDTO, Employee_Task>();
        }
    }
}