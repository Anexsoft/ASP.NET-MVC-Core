using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetcoreProject.Models;
using Model.Domain;
using System.IO;
using Service;

namespace NetcoreProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbumService _albumService;

        public HomeController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

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

            var path = $"wwwroot\\uploads\\{model.Photo.FileName}";

            using (var stream = new FileStream(path, FileMode.Create))
            {
                model.Photo.CopyTo(stream);
            }

            var album = new Album
            {
                Name = model.Name,
                Description = model.Description,
                PhotoLink = $"/uploads/{model.Photo.FileName}"
            };

            _albumService.Create(album);

            return RedirectToAction("Index");
        }
    }
}
