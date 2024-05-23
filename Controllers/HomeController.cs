//Krupali Patel 
//CPT 231-S14
//Assignment 7 03/13/2022

using M7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace M7.Controllers
{
    public class HomeController : Controller
    {
        
        private BtsContext btsContext { get; set; }

        public HomeController(BtsContext btsContext)
        {
            this.btsContext = btsContext;
        }
        [HttpGet]
        public IActionResult Index() //get and list infor 
        {
            List<Bts> bts = btsContext.Bts.OrderBy(
                c => c.BtsId).ToList<Bts>();
            return View(bts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
