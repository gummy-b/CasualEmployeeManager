using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Casual_Emp;
using CasualEmployee.API.DTOs.Employees;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CEmployeesController : ControllerBase
    {
        private readonly ICasualEmpRepo _repo;
        private readonly IMapper _mapper;

        public CEmployeesController(ICasualEmpRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeReadDTO>> Employees()
        {
            var employees = _repo.GetAllEmployees();

            return Ok(_mapper.Map<IEnumerable<EmployeeReadDTO>>(employees));
        }

        [HttpGet("{id}", Name = "GetEmployee")]
        public ActionResult<EmployeeReadDTO> GetEmployee(int id)
        {
            var employee = _repo.GetEmployee(id);

            if (employee != null)
            {
                return Ok(_mapper.Map<EmployeeReadDTO>(employee));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<EmployeeReadDTO> AddEmployee(EmployeeCreateDTO createDTO)
        {
            var employeeModel = _mapper.Map<CEmployee>(createDTO);

            // add converted model
            _repo.CreateEmployee(employeeModel);
            // save changes
            _repo.SaveChanges();

            // created at route
            var employeeReadDTO = _mapper.Map<EmployeeReadDTO>(employeeModel);

            return CreatedAtRoute(nameof(GetEmployee), new { id = employeeReadDTO.Id }, employeeReadDTO);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(int id, UpdateEmployeeDTO updateDTO)
        {
            var employeeModelFromRepo = _repo.GetEmployee(id);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(updateDTO, employeeModelFromRepo);

            _repo.UpdateEmployee(employeeModelFromRepo);
            _repo.SaveChanges();

            return NoContent();
        }

    }// end class
}// end namespace