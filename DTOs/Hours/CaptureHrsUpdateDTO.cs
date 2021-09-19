using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CasualEmployee.API.Models;

namespace CasualEmployee.API.DTOs.Hours
{
    public class CapturedHrsUpdateDTO
    {
        [Required(ErrorMessage = "Task name is required")]
        [DisplayName("Task Name")]
        public int AssignedTaskId { get; set; }
        [Required(ErrorMessage = "Employee selection is required")]
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Hours worked field is required")]
        [DisplayName("Hours Worked")]
        public int HoursWorked { get; set; }
        [Required(ErrorMessage = "Date of capture is required")]
        [DataType(DataType.Date)]
        [DisplayName("Date Captured")]
        public DateTime DateCaptured { get; set; }
        public ICollection<Assign_Task> AssignmentTasks { get; set; }
        public ICollection<CEmployee> Employees { get; set; }
    }
}