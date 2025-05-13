using Microsoft.AspNetCore.Mvc;
using SheltersAndHomesService.Models;

namespace SheltersAndHomesService.Controllers
{
    public class SectionController : Controller
    {
        public IActionResult Orphanage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrphanageDetails(OrphanageDetailsModel model)
        {
            return View(model);
        }
    }
}
