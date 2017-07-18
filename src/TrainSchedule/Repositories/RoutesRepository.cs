using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainSchedule.Data;
using TrainSchedule.Models;

namespace TrainSchedule.Repositories
{
    public class RoutesRepository
    {
        private readonly ApplicationDbContext _db;

        public RoutesRepository(ApplicationDbContext db)
        {
            _db = db;
        }       

        public IEnumerable<Route> GetAllRoutes()
        {
            return _db.Routes.Include(r => r.FinishLocation)
                .Include(r => r.StartLocation)
                .Include(r => r.Train);
        }

        public void AddRoute(Route route)
        {
            _db.Routes.Add(route);
            _db.SaveChanges();
        }

        public void UpdateRoute(Route route)
        {
            _db.Routes.Update(route);
            _db.SaveChanges();
        }

        public Boolean DeleteRoute(Int32 routeId)
        {
            try
            {
                Route routeToDelete = _db.Routes.FirstOrDefault(r => r.Id == routeId);
                if (routeToDelete != null)
                {
                    _db.Routes.Remove(routeToDelete);
                    _db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

    }
}
