﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
