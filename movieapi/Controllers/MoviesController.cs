using Microsoft.AspNetCore.Mvc;
using movieapi.Interfaces;
using movieapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using movieapi.DTOs;
using Microsoft.AspNetCore.JsonPatch;

namespace movieapi.Controllers
{
    [ApiController, Route("api/[controller]")]
    [Consumes("application/json")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _repo;
        private readonly IMapper _mapper;

        public MoviesController(IMovieRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //GET api/movies/
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovies()
        {

            var movies = _repo.GetAllMovies();
            return Ok(movies);
        }


        //GET api/movies/id
        [HttpGet("{id}", Name = "GetMovieById")]
        public ActionResult<MovieReadDTO> GetMovieById(int id)
        {
            var movie = _repo.GetMovieById(id);
            var movieDTO = _mapper.Map<MovieReadDTO>(movie);

            if (movie != null)
            {
                return Ok(movieDTO);
            }

            return NotFound();
        }

        //POST api/movies
        [HttpPost]
        public ActionResult<MovieReadDTO> AddMovie(MovieCreateDTO movieCreateDTO)
        {
            var movieModel = _mapper.Map<Movie>(movieCreateDTO);

            _repo.AddMovie(movieModel);
            _repo.SaveChanges();

            var movieReadDTO = _mapper.Map<MovieReadDTO>(movieModel);

            //returns the route where object is created + body
            return CreatedAtRoute(nameof(GetMovieById), new { Id = movieReadDTO.Id }, movieReadDTO);
        }

        //PUT api/movies/id
        [HttpPut("{id}")]
        public ActionResult UpdateMovie(int id, MovieUpdateDTO movieUpdateDTO)
        {
            var movieModel = _repo.GetMovieById(id); //get current ver of model
            if (movieModel == null)
            {
                return NotFound();
            }

            _mapper.Map(movieUpdateDTO, movieModel); //replace current ver with updated model 

            _repo.UpdateMovie(movieModel); //arbitrary

            _repo.SaveChanges();

            return NoContent();
        }

        //PATCH api/movies/id
        [HttpPatch("{id}")]
        public ActionResult PartialUpdate(int id, JsonPatchDocument<MovieUpdateDTO> patchDoc)
        {
            var movieFromRepo = _repo.GetMovieById(id);

            if(movieFromRepo == null)
            {
                return NotFound();
            }

            var movieToPatch = _mapper.Map<MovieUpdateDTO>(movieFromRepo);

            patchDoc.ApplyTo(movieToPatch, ModelState);

            if (!TryValidateModel(movieToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(movieToPatch, movieFromRepo);

            _repo.UpdateMovie(movieFromRepo);

            _repo.SaveChanges();

            return NoContent();
        }

        //DELETE api/movies/id
        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            var movieToDelete = _repo.GetMovieById(id);
            if(movieToDelete == null)
            {
                return NotFound();
            }
            _repo.DeleteMovie(movieToDelete);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}
