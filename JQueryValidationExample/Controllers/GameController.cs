using JQueryValidationExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace JQueryValidationExample.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            return Json(new { redirect = "/Game" });
        }
    }
}
