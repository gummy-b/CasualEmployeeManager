using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Assignments;
using CasualEmployee.API.DTOs.Assignemnts;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/assign")]
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentRepo _repo;
        private readonly IMapper _m;

        public AssignmentsController(IAssignmentRepo repo, IMapper mapper)
        {
            _repo = repo;
            _m = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AssignmentReadDTO>> Assignments()
        {
            var assignmentItems = _repo.GetAllAssignments();
            return Ok(_m.Map<IEnumerable<AssignmentReadDTO>>(assignmentItems));
        }

        [HttpGet("{id}", Name = "GetAssignment")]
        public ActionResult<AssignmentReadDTO> GetAssignment(int id)
        {
            var assignment = _repo.GetAssignedTask(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return Ok(_m.Map<AssignmentReadDTO>(assignment));
        }

        [HttpPost]
        public ActionResult<AssignmentReadDTO> AssignTask(AssignmentCreateDTO assignmentDTO)
        {
            var assignmentModel = _m.Map<Assign_Task>(assignmentDTO);
            _repo.AssignTask(assignmentModel);

            _repo.SaveChanges();

            var assignmentReadDTO = _m.Map<AssignmentReadDTO>(assignmentModel);

            return CreatedAtRoute(nameof(GetAssignment), new { Id = assignmentReadDTO.Id }, assignmentReadDTO);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateAssignment(int id, AssignmentUpdateDTO updateDto)
        {
            var assignmentFromModel = _repo.GetAssignedTask(id);

            if (assignmentFromModel == null)
            {
                return NotFound();
            }

            _m.Map(updateDto, assignmentFromModel);
            _repo.UpdateAssignment(assignmentFromModel);

            _repo.SaveChanges();

            return NoContent();
        }
    }
}