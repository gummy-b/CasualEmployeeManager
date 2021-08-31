using System.Collections.Generic;
using AutoMapper;
using CasualEmployee.API.Data;
using CasualEmployee.API.DTOs.Roles;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        // Global variables
        private readonly IRolesRepo _repo;
        private readonly IMapper _mapper;

        // Constructor
        public RolesController(IRolesRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // Endpoints
        [HttpGet]
        public ActionResult<IEnumerable<RolesReadDTO>> AllRoles()
        {
            var roleItems = _repo.GetAllRoles();

            return Ok(_mapper.Map<IEnumerable<RolesReadDTO>>(roleItems));
        }

        [HttpGet("{id}")]
        public ActionResult<RolesReadDTO> GetRole(int id)
        {
            var roleItem = _repo.GetRoles(id);
            if (roleItem != null)
            {
                return Ok(_mapper.Map<RolesReadDTO>(roleItem));
            }

            return NotFound();
        }
    }
}