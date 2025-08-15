using Microsoft.AspNetCore.Mvc;
using OpenLayersMapApp.Models;

namespace OpenLayersMapApp.Controllers
{
    namespace OpenLayersMapApp.Controllers
    {
        public class MapController : Controller
        {
            // GET: Map
            public ActionResult Index()
            {
                var locations = new List<Location>
            {
                new Location { Name = "NULL ISLAND", Latitude = 0, Longitude = 0},
                new Location { Name = "TEST", Latitude = 25, Longitude = 0},
                new Location { Name = "TEST", Latitude = 0, Longitude = 25},
                new Location { Name = "TEST", Latitude = -25, Longitude = 0},
                new Location { Name = "TEST", Latitude = 0, Longitude = -25},
                new Location { Name = "TEST", Latitude = -33.96266435065533, Longitude =  25.480179905113356},
                new Location { Name = "ACCRA", Latitude = 5.5580, Longitude = -0.1994},
                new Location { Name = "toets", Latitude = -33.32903721263356, Longitude = 24.881818415943172},
                new Location { Name = "toets", Latitude = -24.6716577656802,  Longitude = 25.89161912772295},
                new Location { Name = "eh", Latitude = -18.149025119535096, Longitude = 25.27896592590194},
            };

                return View(locations);
            }
        }
    }
}
