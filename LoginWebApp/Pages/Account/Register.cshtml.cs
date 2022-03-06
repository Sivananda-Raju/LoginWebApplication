using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginWebApp.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public Credentials credentials { get; set; }
        public void OnGet()
        {

        }
    }
}
