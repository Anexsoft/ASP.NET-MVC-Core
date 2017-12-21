using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using System;

namespace Service
{
    public interface IPhotoService
    {
        bool Create(Photo model);
    }

    public class PhotoService : IPhotoService
    {
        private readonly AlbumDbContext _context;

        public PhotoService(
            AlbumDbContext context
        )
        {
            _context = context;
        }

        public bool Create(Photo model)
        {
            try
            {
                model.CreatedAt = DateTime.Now;
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
