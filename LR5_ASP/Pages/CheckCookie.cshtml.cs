using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR5_ASP.Pages
{
    public class CheckCookieModel : PageModel
    {
        public string CookieValue { get; set; }

        public IActionResult OnGet()
        {
            CookieValue = Request.Cookies["MyCookie"];
            return Page();
        }
    }
}
