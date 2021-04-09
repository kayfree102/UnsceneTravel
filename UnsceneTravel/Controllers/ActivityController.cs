using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnsceneTravel.Controllers
{
    public class Activities : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> name = new List<string>();

            name.Add("Bowling");
            name.Add("Cavern Climb");

            ViewBag.names = name;


            return View();
        }
    public IActionResult Add()
    {
            return View();

        }
    
        //Add new activity to list of activities
    }
}
