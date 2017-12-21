using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace NetcoreProject.Models
{
    public class PhotoViewModel
    {
        [Required]
        public int AlbumId { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
