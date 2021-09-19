using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Assignments;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/assign")]
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentRepo _repo;

        public AssignmentsController(IAssignmentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Assign_Task>> Assignments()
        {
            return Ok(_repo.GetAllAssignments());
        }

        [HttpGet("{id}")]
        public ActionResult<Assign_Task> GetAssignment(int id)
        {
            var assignment = _repo.GetAssignedTask(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return Ok(assignment);
        }

        [HttpPost]
        public ActionResult AssignTask(Assign_Task assignment)
        {
            _repo.AssignTask(assignment);

            //_repo.SaveChanges();

            return NoContent();
        }
    }
}