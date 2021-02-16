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
        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{Id = 0, Title = "Scary movie", ReleaseDate = 2019, Genre = "Horror", Runtime = 120},
                new Movie{Id = 1, Title = "Exciting movie", ReleaseDate = 1996, Genre = "Action", Runtime = 221},
                new Movie{Id = 2, Title = "Funny movie", ReleaseDate = 2022, Genre = "Comedy", Runtime = 96}
            };

            return movies;
        }

        public Movie GetMovieById(int id)
        {
            return new Movie
            {
                Id = 0,
                Title = "Scary movie",
                ReleaseDate = 2019,
                Genre = "Horror",
                Runtime = 120
            };
        }
    }
}
