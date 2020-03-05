using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class NorthwindController : Controller
    {
        public IActionResult Index()
        {
            NorthwindDb db = new NorthwindDb(@"Data Source=.\sqlexpress;Initial Catalog=Northwnd;Integrated Security=True;");
            ProductsViewModel vm = new ProductsViewModel
            {
                Products = db.GetProducts()
            };
            return View(vm);
        }
    }
}