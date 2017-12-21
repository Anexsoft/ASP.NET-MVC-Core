using Microsoft.EntityFrameworkCore;
using Model.Domain;

namespace Model
{
    public class AlbumDbContext : DbContext
    {
        public AlbumDbContext(DbContextOptions<AlbumDbContext> options)
            : base(options)
        {

        }

        public DbSet<Album> Album { get; set; }
        public DbSet<Photo> Photo { get; set; }
    }
}
