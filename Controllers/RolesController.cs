using System.Collections.Generic;
using CasualEmployee.API.Data;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRolesRepo _repo;

        public RolesController(IRolesRepo repo)
        {
            _repo = repo;
        }

        //GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<Roles>> AllRoles()
        {
            var roleItems = _repo.GetAllRoles();

            return Ok(roleItems);
        }

        //GET
        //api/roles/5
        [HttpGet("{id}")]
        public ActionResult<Roles> GetRole(int id)
        {
            var roleItem = _repo.GetRoles(id);

            return Ok(roleItem);
        }
    }
}