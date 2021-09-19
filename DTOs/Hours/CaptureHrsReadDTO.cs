using System;
using System.Collections.Generic;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.DTOs.Hours
{
    public class CapturedHrsReadDTO
    {
        public int Id { get; set; }
        public int AssignedTaskId { get; set; }
        public int EmployeeId { get; set; }
        public int HoursWorked { get; set; }
        public DateTime DateCaptured { get; set; }
        public ICollection<Assign_Task> AssignmentTasks { get; set; }
        public ICollection<CEmployee> Employees { get; set; }
    }
}