using Microsoft.AspNetCore.Mvc;
using Service;

namespace NetcoreProject.Views.Shared.Components.AlbumGallery
{
    public class AlbumGallery : ViewComponent
    {
        private readonly IAlbumService _albumService;

        public AlbumGallery(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IViewComponentResult Invoke()
        {
            return View(
                _albumService.GetAll()
            );
        }
    }
}
