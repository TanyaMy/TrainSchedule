using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrainSchedule.Controllers
{
    public class TrainsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}