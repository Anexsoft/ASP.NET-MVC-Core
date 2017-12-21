using Microsoft.AspNetCore.Mvc;
using Service;
using System.Linq;

namespace NetcoreProject.Areas.Api.Controllers
{
    [Area("Api")]
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(
            IAlbumService albumService
        )
        {
            _albumService = albumService;
        }

        [Route("api/album/{albumId}")]
        public IActionResult Get(int albumId) {
            var result = _albumService.Get(albumId);

            return Ok(
                new
                {
                    Name = result.Name,
                    Description = result.Description,
                    Photos = result.Photos.Select(x => x.PhotoLink).ToList()
                }
            );
        }
    }
}
