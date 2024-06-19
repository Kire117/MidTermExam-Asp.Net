using System.ComponentModel.DataAnnotations;

namespace Std_ID_200579494.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }

}
