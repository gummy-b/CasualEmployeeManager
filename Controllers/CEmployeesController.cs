using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Casual_Emp;
using CasualEmployee.API.DTOs.Employees;
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

        [HttpGet("{id}")]
        public ActionResult<EmployeeReadDTO> GetEmployee(int id)
        {
            var employee = _repo.GetEmployee(id);

            if (employee != null)
            {
                return Ok(_mapper.Map<EmployeeReadDTO>(employee));
            }

            return NotFound();
        }
    }
}