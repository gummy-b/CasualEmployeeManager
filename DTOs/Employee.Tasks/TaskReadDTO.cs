using System;

namespace CasualEmployee.API.DTOs.Employees.Tasks
{
    public class TaskReadDTO
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}