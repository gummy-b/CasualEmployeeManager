using System;

namespace CasualEmployee.API.DTOs.Assignemnts
{
    public class AssignmentReadDTO
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int EmployeeId { get; set; }
        public int Task_Duration { get; set; }
        public DateTime Date_Assigned { get; set; }
    }
}