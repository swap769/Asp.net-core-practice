using System.ComponentModel.DataAnnotations;

namespace MyFirstWeb.Models
{
    public class EmployeeDatabase
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Designation { get; set; }
        public int PhoneNo { get; set; }
    }
}
