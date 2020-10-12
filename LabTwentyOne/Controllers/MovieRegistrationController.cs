using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabTwentyOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabTwentyOne.Controllers
{
    public class MovieRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrationConfirmation(MovieModel model)
        {
            return View(model);
        }
    }
}
