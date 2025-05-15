using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a name")]
        [Display(Name = "Name", Prompt = "Name")]
        [RegularExpression("[a-zA-ZåäöÅÄÖ]*", ErrorMessage = "Write a valid name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail is a must.")]
        [EmailAddress(ErrorMessage = "Invalid e-mail.")]
        [Display(Name = "Email", Prompt = "Email")]
        public string Email { get; set; } // 
    }
}
