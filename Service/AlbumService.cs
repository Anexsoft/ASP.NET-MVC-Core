using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public interface IAlbumService
    {
        bool Create(Album model);
        IEnumerable<Album> GetAll();
        Album Get(int albumIn);
    }

    public class AlbumService : IAlbumService
    {
        private readonly AlbumDbContext _context;

        public AlbumService(
            AlbumDbContext context
        )
        {
            _context = context;
        }

        public bool Create(Album model)
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

        public IEnumerable<Album> GetAll()
        {
            var result = new List<Album>();

            try
            {
                result = _context.Album.OrderByDescending(x => x.CreatedAt)
                              .ToList();
            }
            catch (Exception)
            {
                
            }

            return result;
        }

        public Album Get(int albumId)
        {
            var result = new Album();

            try
            {
                result = _context.Album.Include(x => x.Photos)
                                       .Single(x => x.Id == albumId);
            }
            catch (Exception)
            {

            }

            return result;
        }
    }
}
