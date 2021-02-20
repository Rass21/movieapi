using AutoMapper;
using movieapi.DTOs;
using movieapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieapi.Profiles
{
    public class MoviesProfile : Profile
    {
        public MoviesProfile()
        {
            //Source -> target
            CreateMap<Movie, MovieReadDTO>();
            CreateMap<MovieCreateDTO, Movie>();
            CreateMap<MovieUpdateDTO, Movie>();
            CreateMap<Movie, MovieUpdateDTO>();
        }
    }
}
