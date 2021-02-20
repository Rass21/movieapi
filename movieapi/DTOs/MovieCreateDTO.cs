﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.DTOs
{
    public class MovieCreateDTO
    {
        [Required]
        public string Title { get; set; }

        public int ReleaseDate { get; set; }

        public string Genre { get; set; }

        public int Runtime { get; set; }
    }
}
