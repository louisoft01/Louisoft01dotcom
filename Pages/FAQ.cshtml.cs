using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Louisoft01.com.Pages
{
    public class FAQ : PageModel
    {
        public FAQ(string message)
        {
            Message = message;
        }

        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}
