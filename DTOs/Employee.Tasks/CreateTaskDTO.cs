using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CasualEmployee.API.DTOs.Employees.Tasks
{
    public class CreateTaskDTO
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Task Name")]
        public string TaskName { get; set; }
        [Required]
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}