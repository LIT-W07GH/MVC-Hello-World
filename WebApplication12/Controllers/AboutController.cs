using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Me()
        {
            return View();
        }
    }
}
