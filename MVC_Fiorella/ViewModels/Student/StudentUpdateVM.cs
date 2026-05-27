using System.ComponentModel.DataAnnotations;

namespace MVC_Fiorella.ViewModels.Student
{
    public class StudentUpdateVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public decimal Grade { get; set; }
        [Required]
        public string Group { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Faculty { get; set; }
    }
}
