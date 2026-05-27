using System.ComponentModel.DataAnnotations;

namespace MVC_Fiorella.ViewModels.Student
{
    public class StudentCreateVM
    {
        [Required(ErrorMessage ="Ad bos qoyula bilmez")]
        [MaxLength(20, ErrorMessage = "Ad 20 simvoldan uzun ola bilmez")]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
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
