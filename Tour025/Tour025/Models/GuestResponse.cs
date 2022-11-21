using System.ComponentModel.DataAnnotations;

namespace Tour025.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name!")] 
        public string? Name { get; set; }


        [Required(ErrorMessage = "Please enter your Email!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number!")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend!")]
        public bool? WillAttend { get; set; }
    }
}
