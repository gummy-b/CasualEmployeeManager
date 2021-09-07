using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Casual_Emp;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CEmployeesController : ControllerBase
    {
        private readonly ICasualEmpRepo _repo;

        public CEmployeesController(ICasualEmpRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CEmployee>> Employees()
        {
            var employees = _repo.GetAllEmployees();

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<CEmployee> GetEmployee(int id)
        {
            var employee = _repo.GetEmployee(id);

            if (employee != null)
            {
                return Ok(employee);
            }

            return NotFound();
        }
    }
}