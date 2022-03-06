using System.ComponentModel.DataAnnotations;

namespace LoginWebApp.Pages.Account
{
    public class Credentials
    {
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}