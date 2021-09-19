using System.Collections.Generic;
using CasualEmployee.API.Data.Repos.Hours;
using CasualEmployee.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasualEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaptureHoursController : ControllerBase
    {
        private readonly IHoursRepo _repo;

        public CaptureHoursController(IHoursRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hours_Worked>> CapturedHours()
        {
            var captureHours = _repo.EmployeeHoursWorked();

            return Ok(captureHours);
        }

        [HttpGet("{id}", Name = "GetHoursCaptured")]
        public ActionResult<Hours_Worked> GetHoursCaptured(int id)
        {
            var capturedHour = _repo.EmployeeHourWorked(id);

            if (capturedHour == null)
            {
                return NotFound();
            }

            return Ok(capturedHour);
        }

        [HttpPost]
        public ActionResult<Hours_Worked> CaptureHour(Hours_Worked capture)
        {
            _repo.CaptureHours(capture);

            // _repo.SaveChanges();

            return Ok(capture);
        }
    }
}