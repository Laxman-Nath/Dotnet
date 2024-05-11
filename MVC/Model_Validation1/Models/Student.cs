using System.ComponentModel.DataAnnotations;
namespace Model_Validation1.Models
{
    public class Student
    {
        [Required(ErrorMessage ="The name field cannot be left empty")]
        [StringLength(10,MinimumLength =5,ErrorMessage="The length should not be greater than 10 and should not be less than 5")]
        public string Name { get; set; }

        [Required(ErrorMessage ="The email field cannot be left empty")]
        [EmailAddress(ErrorMessage ="The format should match to email only")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Age is must")]
        [Range(10,50,ErrorMessage ="The age must be between 10 and 50")]
        public int? Age { get; set; }
    }
}
