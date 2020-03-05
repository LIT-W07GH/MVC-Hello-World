using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class PageController : Controller
    {
        public IActionResult One()
        {
            return View();
        }

        public IActionResult Two()
        {
            return View();
        }
    }
}
