using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.Data.Repos.Hours
{
    public interface IHoursRepo
    {
        IEnumerable<Hours_Worked> EmployeeHoursWorked();
        Hours_Worked EmployeeHourWorked(int id);
        void CaptureHours(Hours_Worked captureHours);
        bool SaveChanges();
    }
}