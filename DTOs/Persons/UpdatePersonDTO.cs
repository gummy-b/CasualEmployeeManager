using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CasualEmployee.API.DTOs.Persons
{
    public class UpdatePersonDTO
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Surname")]
        public string LastName { get; set; }
        [Required]
        [MinLength(10)]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public string ProfilePicture { get; set; }
    }
}