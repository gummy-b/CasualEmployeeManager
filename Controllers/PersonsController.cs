using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Persons;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepo _repo;

        public PersonsController(IPersonRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Person>> AllPersons()
        {
            var people = _repo.AllPeople();

            return Ok(people);
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            var person = _repo.GetPerson(id);

            if (person != null)
            {
                return Ok(person);
            }

            return NotFound();
        }
    }
}