using System;
using System.Collections.Generic;
using System.Linq;
using CasualEmployee.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CasualEmployee.API.Data.Repos.Hours
{
    public class HoursRepo : IHoursRepo
    {
        private readonly CEContext _con;

        public HoursRepo(CEContext con)
        {
            _con = con;
        }
        public void CaptureHours(Hours_Worked captureHours)
        {
            if (captureHours == null)
            {
                throw new ArgumentNullException(nameof(captureHours));
            }

            _con.HoursWorked.Add(captureHours);
        }

        public IEnumerable<Hours_Worked> EmployeeHoursWorked()
        {
            return _con.HoursWorked.Include(mhr => mhr.AssignmentTasks)
                                    .ThenInclude(t => t.E_Tasks)
                                    .Include(e => e.Employees)
                                    .ToList();
        }

        public Hours_Worked EmployeeHourWorked(int id)
        {
            return _con.HoursWorked.Include(mhr => mhr.AssignmentTasks)
                                    .ThenInclude(t => t.E_Tasks)
                                    .Include(e => e.Employees)
                                    .FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_con.SaveChanges() >= 0);
        }
    }
}