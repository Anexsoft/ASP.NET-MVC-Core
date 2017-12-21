using System;

namespace Model.Domain
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoLink { get; set; }
        public DateTime CreatedAt { get; set; }

        public Album Album { get; set; }
        public int AlbumId { get; set; }
    }
}
