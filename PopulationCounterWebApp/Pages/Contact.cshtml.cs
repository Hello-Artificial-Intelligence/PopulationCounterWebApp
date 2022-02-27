using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PopulationCounterWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string name = "";
        public string email = "";
        public string message = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            hasData = true;
            name = Request.Form["name"];
            email = Request.Form["email"];
            message = Request.Form["message"];
        }
    }
}
