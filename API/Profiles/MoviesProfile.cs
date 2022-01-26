using AutoMapper;
using MoviesRentalAPI.Entities;
using MoviesRentalAPI.HelperEntities;
using MoviesRentalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Profiles
{
    public class MoviesProfile : Profile
    {
        public MoviesProfile()
        {
            CreateMap<CustomMovie, CustomMovieDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieForCreationDto, Movie>();
            CreateMap<MovieForUpdateDto, Movie>();
            CreateMap<Movie, MovieForUpdateDto>();
        }
    }
}
