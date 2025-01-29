using System.ComponentModel.DataAnnotations;

namespace DNC_DemoMVCWebAppWithData.Models
{
    public class Person
    {
        [Display(Name = "Identity")]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string? Name { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}
