using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Runtime { get; set; }
    }
}
