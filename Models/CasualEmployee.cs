using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CasualEmployee.API.Models
{
    public class CasualEmployee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Avatar")]
        public string ProfilePicture { get; set; }
        [Required]
        [DisplayName("Role Name")]

        #region 
        public string Role { get; set; }
        // Foreign key(s)
        public int RoleId { get; set; }
        public int PersonId { get; set; }
        // Navigation properties
        public Roles RoleNav { get; set; }
        public Person Person { get; set; }
        #endregion
    }
}