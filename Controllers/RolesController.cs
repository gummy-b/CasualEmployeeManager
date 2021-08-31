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

        [HttpGet("{id}", Name = "GetRole")]
        public ActionResult<RolesReadDTO> GetRole(int id)
        {
            var roleItem = _repo.GetRoles(id);
            if (roleItem != null)
            {
                return Ok(_mapper.Map<RolesReadDTO>(roleItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<RolesReadDTO> AddRole(int id, RolesCreateDTO rolesAddDTO)
        {
            // Map incoming dto back to a model
            var roleItemModel = _mapper.Map<Roles>(rolesAddDTO);
            _repo.AddRole(roleItemModel);

            // Flush changes into Db
            _repo.SaveChanges();

            var rolesReadDTO = _mapper.Map<RolesReadDTO>(roleItemModel);

            return CreatedAtRoute(nameof(GetRole), new { id = rolesReadDTO.Id }, rolesReadDTO);

        }
    }
}