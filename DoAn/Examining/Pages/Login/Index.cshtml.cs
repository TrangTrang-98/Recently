
using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;

using ApplicationCore.Entities;

using Microsoft.AspNetCore.Http;

namespace Examining.Pages.Login

{

    public class LoginModel : PageModel

    {
            public string msg{get; set;}
             [BindProperty]
            public string username{get; set;}
             [BindProperty]            
             public string password{get; set;}
            public IActionResult OnPost()
            {
                if (username != null && password != null && username.Equals("Admin") && password.Equals("admin"))
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToPage("Index");
             }
            else
            {
                msg = "Tai khoan hoac mat khau khong dung";
                return Page();
            }
            }           

    }

}