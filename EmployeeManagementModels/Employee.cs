using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "FirstName is mandatory")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "pragimtech.com")]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }

        public string PhotoPath { get; set; }

        public Department Department { get; set; }



    }
}
