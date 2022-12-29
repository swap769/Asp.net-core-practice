﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace MyFirstWeb.Models
{
    public class Userdata
    {
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter dob")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please enter designation")]
        public string Designation { get; set;}

        [Required(ErrorMessage = "Please enter salary")]
        public int Salary { get; set;}

        [Required(ErrorMessage = "Please enter Gender")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Please enter married")]
        public string Married { get; set;}
    }
    public enum Gender
    {
        MALE,
        FEMALE,
    }
}
