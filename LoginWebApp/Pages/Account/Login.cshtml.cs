using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LoginWebApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credentials credentials { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            if(credentials.UserName =="admin" && credentials.Password=="password")
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name,"admin"),
                                               new Claim(ClaimTypes.Email,"admin@dell.com")};
                var identity = new ClaimsIdentity(claims,"MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookieAuth",claimsPrincipal);
                return RedirectToPage("/index");
            }
            return Page();
        }
    }
}
