using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasualEmployee.API.Models
{
    public class Assign_Task
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Task")]
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
        public ICollection<CEmployee> Employees { get; set; }
        public ICollection<Employee_Task> E_Tasks { get; set; }
    }
}