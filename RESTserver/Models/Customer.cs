using System.ComponentModel.DataAnnotations;

namespace RESTserver.Models
{
    public class Customer
    {
        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        [Range (19,int.MaxValue, ErrorMessage = "Age can be above 18")]
        public int age { get; set; }

        [Required]
        public int id { get; set; }

        public string getFullName()
        {
            return lastName + firstName;
        }

        public override string ToString()
        {
            return id + " " + firstName + " " + lastName;
        }
    }
}
