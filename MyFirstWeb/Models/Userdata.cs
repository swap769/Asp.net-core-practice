using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace MyFirstWeb.Models
{
    public class Userdata
    {
        [Required(ErrorMessage = "Please Enter Username"),DataType(DataType.Text),StringLength(20,MinimumLength =3,ErrorMessage ="Name must be in 3 to 20 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter email"),DataType(DataType.EmailAddress),
            RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter dob")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please enter designation")]
        public string? Designation { get; set;}

        [Required(ErrorMessage = "Please enter salary")]
        public int Salary { get; set;}

        [Required(ErrorMessage = "Please enter Gender")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Please enter married")]
        public string? Married { get; set;}

        [Required(ErrorMessage ="please enter age"),Range(18,60)]
        public int Age { get; set; }

        [Required(ErrorMessage = "please enter password"),
            RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",
            ErrorMessage ="Minimum 8 character with uparcase,lowercase alphabets,numbers and special symbols")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Password does not match"),
            RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",
            ErrorMessage = "Minimum 8 character with uparcase,lowercase alphabets,numbers and special symbols"),
            Compare("Password"),Display(Name ="Confirm Password")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Url is must")]
        public string? Url { get; set; }

    }
    public enum Gender
    {
        MALE,
        FEMALE,
    }
}
