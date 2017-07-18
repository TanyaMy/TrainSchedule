using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TrainSchedule.Repositories;
using TrainSchedule.Data;
using TrainSchedule.Models;
using System.Collections.Generic;
using System.Linq;

namespace TrainSchedule.Controllers
{
    [Authorize]
    public class RoutesController : Controller
    {
        private readonly RoutesRepository _routesRepository;

        public RoutesController(ApplicationDbContext db)
        {
            _routesRepository = new RoutesRepository(db);
        }        

        public IActionResult Index()
        {
            List<Route> routes = _routesRepository.GetAllRoutes().ToList();
            return View(routes);
        }
    }
}