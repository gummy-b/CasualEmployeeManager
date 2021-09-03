using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Persons;
using CasualEmployee.API.DTOs.Persons;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepo _repo;
        private readonly IMapper _mapper;

        public PersonsController(IPersonRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonReadDTO>> AllPersons()
        {
            var people = _repo.AllPeople();

            return Ok(_mapper.Map<IEnumerable<PersonReadDTO>>(people));
        }

        [HttpGet("{id}")]
        public ActionResult<PersonReadDTO> GetPerson(int id)
        {
            var person = _repo.GetPerson(id);

            if (person != null)
            {
                return Ok(_mapper.Map<PersonReadDTO>(person));
            }

            return NotFound();
        }
    }
}