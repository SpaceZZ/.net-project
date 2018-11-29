using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Api.Controllers
{
    public class CitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}