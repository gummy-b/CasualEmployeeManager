using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasualEmployee.API.DTOs.Roles
{
    public class UpdateRoleDTO
    {
        [DisplayName("Role")]
        [Required]
        public string RoleName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal RoleRate { get; set; }
    }
}