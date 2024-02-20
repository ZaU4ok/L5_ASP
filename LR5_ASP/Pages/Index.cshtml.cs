using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR5_ASP.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnPost(string value, DateTime expiry)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Response.Cookies.Append("MyCookie", value, new CookieOptions
                {
                    Expires = expiry,
                    IsEssential = true
                });
            }
            return RedirectToPage("/CheckCookie");
        }
    }
}
