﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.DTOs
{
    public class MovieUpdateDTO
    {
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }


        public int ReleaseDate { get; set; }

        [MaxLength(50)]
        public string Genre { get; set; }


        public int Runtime { get; set; }
    }
}
