using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CasualEmployee.API.DTOs.Assignemnts
{
    public class AssignmentCreateDTO
    {
        public int TaskId { get; set; }
        [DisplayName("Employee")]
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        [DisplayName("Task Duration")]
        public int Task_Duration { get; set; }
        [Required]
        [DisplayName("Date Assigned")]
        public DateTime Date_Assigned { get; set; }
    }
}