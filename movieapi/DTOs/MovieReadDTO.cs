﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.DTOs
{
    public class MovieReadDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int ReleaseDate { get; set; }

        public string Genre { get; set; }

        public int Runtime { get; set; }
    }
}
