using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopulationCounterWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public bool hasData = false;
        public string name = "";
        public string fathername = "";
        public string mothername = "";
        public string age = "";
        public string religion = "";
        public string phonenumber = "";
        public string state = "";
        public string city = "";
        public string house = "";
        public string email = "";
        public bool hasVerify = false;
        public string varificationid = "";
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            hasData = true;
            name = Request.Form["name"];
            fathername = Request.Form["fathername"];
            mothername = Request.Form["mothername"];
            age = Request.Form["age"];
            religion = Request.Form["religion"];
            phonenumber = Request.Form["phonenumber"];
            state = Request.Form["state"];
            city = Request.Form["city"];
            house = Request.Form["house"];
            email = Request.Form["email"];
            hasVerify = true;
            varificationid = Request.Form["varificationid"];
        }
    }
}
