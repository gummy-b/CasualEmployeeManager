using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasualEmployee.API.Models
{
    public class EmployeeReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfilePicture { get; set; }
        public string RoleName { get; set; }
    }
}