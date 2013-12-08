using System.ComponentModel.DataAnnotations;

namespace SignalRDemo.Models
{
    public class UserModel
    {
        public string FullName { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}