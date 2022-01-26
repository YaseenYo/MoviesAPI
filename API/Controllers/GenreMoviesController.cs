using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoviesRentalAPI.Entities;
using MoviesRentalAPI.Models;
using MoviesRentalAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MoviesRentalAPI.Controllers
{
    [ApiController]
    [Route("api/genres/{genreId}/movies")]
    public class GenreMoviesController : ControllerBase
    {
        private readonly IMoviesRentalRepository _moviesRentalRepository;
        private readonly IMapper _mapper;

        public GenreMoviesController(IMoviesRentalRepository moviesRentalRepository,
                IMapper mapper)
        {
            _moviesRentalRepository = moviesRentalRepository ??
                throw new ArgumentNullException(nameof(moviesRentalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{movieId}", Name = "GetMovie")]
        public async Task<IActionResult> GetMovie(int genreId, int movieId)
        {
            var genreExists = await _moviesRentalRepository.GenreExists(genreId);
            if (!genreExists)
            {
                return NotFound();
            }

            var movieFromRepo = await _moviesRentalRepository.GetMovieAsync(genreId, movieId);
            if (movieFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MovieDto>(movieFromRepo));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateMovieForGenre(int genreId, MovieForCreationDto movie)
        {
            var movieEntity = _mapper.Map<Movie>(movie);
            _moviesRentalRepository.AddMovie(genreId, movieEntity);
            await _moviesRentalRepository.SaveAsync();

            var movieToReturn = _mapper.Map<MovieDto>(movieEntity);
            return CreatedAtRoute("GetMovie",
                        new { genreId = genreId, movieId = movieToReturn.Id }, movieToReturn);

        }

        [HttpPatch]
        [Authorize]
        public async Task<IActionResult> PartiallyUpdateMovie(int genreId, int movieId,
                            JsonPatchDocument<MovieForUpdateDto> jsonPatchDocument)
        {
            var movieFromRepo = await _moviesRentalRepository.GetMovieAsync(genreId, movieId);

            if (movieFromRepo == null)
            {
                return NotFound();
            }

            var movieToPatch = _mapper.Map<MovieForUpdateDto>(movieFromRepo);
            jsonPatchDocument.ApplyTo(movieToPatch,ModelState);

            if (!TryValidateModel(movieToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(movieToPatch, movieFromRepo);

            _moviesRentalRepository.UpdateMovie(movieFromRepo);

            await _moviesRentalRepository.SaveAsync();

            return NoContent();
        }
    }
}
