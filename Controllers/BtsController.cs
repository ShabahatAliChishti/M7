//Krupali Patel 
//CPT 231-S14
//Assignment 7 03/13/2022
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M7.Models;


// editing, adding, deleting database 
namespace M7.Controllers
{
    public class BtsController : Controller
    {
        private BtsContext btsContext { get; set; }

        public BtsController(BtsContext btsContext)
        {
            this.btsContext = btsContext;
        }
       //Adding
       [HttpGet]
       public IActionResult Add()
        {
            ViewBag.Title = "Add";
            return View("AddEdit", new Bts());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Edit";
            Bts bts = btsContext.Bts.Find(id);
            return View("AddEdit", bts);
        }



        [HttpPost]
        public IActionResult AddEdit(Bts bts)
        {
            if(ModelState.IsValid)
            {
                if(bts.BtsId != 0)
                {
                    btsContext.Bts.Update(bts);
                }
                else
                {
                    btsContext.Bts.Add(bts);
                }
                btsContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (bts.BtsId != 0)
                {
                    ViewBag.Title = "Edit";
                }
                else
                {
                    ViewBag.Title = "Add";
                }
                return View("AddEdit", bts);
            }   
        }
        public IActionResult Delete (int id)
        {
            ViewBag.Title = "Delete";
            Bts bts = btsContext.Bts.Find(id);
            return View(bts);
        }

        [HttpPost]
        public IActionResult Delete(Bts bts)
        {
            btsContext.Bts.Remove(bts);
            btsContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
