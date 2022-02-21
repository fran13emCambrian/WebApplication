using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class IntroModel : PageModel
    {
        public string Number1 => (string)TempData[nameof(Number1)];
        public string Number2 => (string)TempData[nameof(Number2)];
        public void OnGet()
        {
        }

        public IActionResult OnPost([FromForm] string Number1, [FromForm] string Number2)
        {
            TempData["Number1"] = Number1; TempData["Number2"] = Number2;
            return RedirectToPage("Intro");
        }

      
    }
}
