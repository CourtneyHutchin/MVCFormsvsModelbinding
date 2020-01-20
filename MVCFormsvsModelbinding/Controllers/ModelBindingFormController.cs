using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCFormsvsModelbinding.Models;

namespace MVCFormsvsModelbinding.Controllers
{
    public class ModelBindingFormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Customer c)
        {
            if(ModelState.IsValid)
            {
                // add to DB
                // CustomerDB.Add
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(c);
            }
        }
    }
}