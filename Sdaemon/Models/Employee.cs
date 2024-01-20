using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sdaemon.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Required (ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Enter Email Address")]
        [EmailAddress (ErrorMessage ="Please Emter Correct Email")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Enter Mobile Number")]
        [StringLength(10, ErrorMessage ="Enter Valid Mobile Number")]
        [DisplayName("Mobile Number")]
        public string Number { get; set; }

        public string Gender { get; set; }
        public string Address { get; set; }
    }
}
