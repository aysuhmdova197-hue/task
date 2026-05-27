namespace MVC_Fiorella.Models
{
    public class Student: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Grade { get; set; }
        public string Group { get; set; }
        public string Phone { get; set; }
        public string Faculty { get; set; }

    }
}
