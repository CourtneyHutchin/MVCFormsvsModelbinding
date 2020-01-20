using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCFormsvsModelbinding.Models;

namespace MVCFormsvsModelbinding.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            Customer c = new Customer();

            c.FullName = data["full-name"];
            c.DateOfBirth = Convert.ToDateTime(data["dob"]);
            c.Email = data["email"];


            // Add to the DB
            ViewData["Message"] = "The customer has been added successfully";

            return View();
        }
    }
}