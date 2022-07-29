using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceOutlet.Web.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {

        public string ReturnUrl { get; set; } = default!;
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl;
        }
    }
}
