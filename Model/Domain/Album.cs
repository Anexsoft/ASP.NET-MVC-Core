using System;
using System.Collections.Generic;

namespace Model.Domain
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoLink { get; set; }
        public DateTime CreatedAt { get; set; }

        public IEnumerable<Photo> Photos { get; set; }
    }
}
