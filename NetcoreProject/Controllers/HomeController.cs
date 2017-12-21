using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetcoreProject.Models;
using Model.Domain;

namespace NetcoreProject.Controllers
{
    public class HomeController : Controller
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
        public IActionResult Insert(AlbumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }

            return RedirectToAction("Index");
        }
    }
}
