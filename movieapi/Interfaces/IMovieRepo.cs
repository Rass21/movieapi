using movieapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Interfaces
{
    public interface IMovieRepo
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
    }
}
