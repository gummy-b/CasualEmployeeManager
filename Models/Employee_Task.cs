using System;

namespace CasualEmployee.API.Models
{
    public class Employee_Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}