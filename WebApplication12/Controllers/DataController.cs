using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    //create a page that will say the following:

    //In a week from today the date will be: March 11th, 2020
    //create a class in the models folder called SimpleViewModel
    //that has one property on it, called DateInAWeek
    //In your controller, new up this object, and set
    //the DateInAWeek property (DateTime.Now.AddDays(7))
    //then, pass this object into your view,
    //and render it

    public class DataController : Controller
    {
        public IActionResult Index()
        {
            DataViewModel vm = new DataViewModel();
            Random rnd = new Random();
            vm.SomeNumber = rnd.Next(1, 1000);
            vm.SomeText = RandomString(rnd.Next(10, 20));
            return View(vm);
        }

        public IActionResult InAWeek()
        {
            SimpleViewModel vm = new SimpleViewModel();
            vm.DateInAWeek = DateTime.Now.AddDays(7);
            return View(vm);
        }

        private string RandomString(int length)
        {
            Random rnd = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}