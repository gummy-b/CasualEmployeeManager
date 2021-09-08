using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Emp_Task;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class EmployeeTasksController : ControllerBase
    {
        private readonly IEmpTaskRepo _repo;
        private readonly IMapper _mapper;

        public EmployeeTasksController(IEmpTaskRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee_Task>> AllTasks()
        {
            var taskItems = _repo.GetAllTasks();

            return Ok(taskItems);
        }

        [HttpGet("{id}", Name = "GetTask")]
        public ActionResult<Employee_Task> GetTask(int id)
        {
            var taskItem = _repo.GetTask(id);

            if (taskItem != null)
            {
                return Ok(taskItem);
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<Employee_Task> AddTask(Employee_Task task)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTask(int id, Employee_Task task)
        {
            return NoContent();
        }
    }
}