using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Emp_Task;
using CasualEmployee.API.DTOs.Employees.Tasks;
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
        public ActionResult<IEnumerable<TaskReadDTO>> AllTasks()
        {
            var taskItems = _repo.GetAllTasks();

            return Ok(_mapper.Map<TaskReadDTO>(taskItems));
        }

        [HttpGet("{id}", Name = "GetTask")]
        public ActionResult<TaskReadDTO> GetTask(int id)
        {
            var taskItem = _repo.GetTask(id);

            if (taskItem != null)
            {
                return Ok(_mapper.Map<TaskReadDTO>(taskItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<TaskReadDTO> AddTask(CreateTaskDTO createTaskDTO)
        {
            var taskModel = _mapper.Map<Employee_Task>(createTaskDTO);

            _repo.CreateTask(taskModel);
            _repo.SaveChanges();

            var readTaskDTO = _mapper.Map<TaskReadDTO>(taskModel);

            return CreatedAtRoute(nameof(GetTask), new { id = readTaskDTO.Id }, readTaskDTO);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTask(int id, Employee_Task task)
        {
            var taskItem = _repo.GetTask(id);
            if (taskItem == null)
            {
                return NotFound();
            }

            _mapper.Map(task, taskItem);

            _repo.UpdateTask(taskItem);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}