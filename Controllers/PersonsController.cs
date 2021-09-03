using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data.Repos.Persons;
using CasualEmployee.API.DTOs.Persons;
using CasualEmployee.API.Models;
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

        [HttpGet("{id}", Name = "GetPerson")]
        public ActionResult<PersonReadDTO> GetPerson(int id)
        {
            var person = _repo.GetPerson(id);

            if (person != null)
            {
                return Ok(_mapper.Map<PersonReadDTO>(person));
            }

            return NotFound();
        }


        [HttpPost]
        public ActionResult<PersonReadDTO> AddPerson(PersonCreateDTO createDto)
        {
            var personModel = _mapper.Map<Person>(createDto);

            _repo.AddPerson(personModel);
            _repo.SaveChanges();

            //map back to read dto 
            var personReadDTO = _mapper.Map<PersonReadDTO>(personModel);

            // return person read dto after create
            return CreatedAtRoute(nameof(GetPerson), new { Id = personReadDTO.Id }, personReadDTO);
        }
    }
}