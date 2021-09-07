using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasualEmployee.API.DTOs.Employees
{
    public class EmployeeCreateDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Avatar")]
        public string ProfilePicture { get; set; }
        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
    }
}