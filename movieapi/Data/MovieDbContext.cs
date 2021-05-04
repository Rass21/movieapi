using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movieapi.Models;

namespace movieapi.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> opt) : base(opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        //public DbSet<Director> Directors { get; set; }
    }
}
