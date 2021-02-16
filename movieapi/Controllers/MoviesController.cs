using Microsoft.AspNetCore.Mvc;
using movieapi.Interfaces;
using movieapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _repo;

        public MoviesController(IMovieRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovies()
        {
            var movies = _repo.GetAllMovies();
            return Ok(movies);
        }


        //GET api/movies/id
        [HttpGet("{id}")]
        public ActionResult <Movie> GetMovie(int id)
        {
            var movie = _repo.GetMovieById(id);

            return Ok(movie);
        }
    }
}
