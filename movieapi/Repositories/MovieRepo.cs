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

        public void AddMovie(Movie movie)
        {
            if(movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }
            _db.Movies.Add(movie);
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

        public void RemoveMovie(Movie movie)
        {
            _db.Remove(movie);
            _db.SaveChanges();
        }

        public bool SaveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

        public void UpdateMovie(Movie movie)
        {
            //
        }
    }
}
