using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace NetcoreProject.Models
{
    public class AlbumViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
