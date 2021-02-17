using movieapi.Data;
using movieapi.Interfaces;
using movieapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Repositories
{
    public class MovieRepo : IMovieRepo
    {
        private readonly MovieDbContext _db;

        public MovieRepo(MovieDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = _db.Movies.ToList();

            return movies;
        }

        public Movie GetMovieById(int id)
        {
            var movie = _db.Movies.Find(id);

            return movie;
        }
    }
}
