using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesRentalAPI.DbContexts;
using MoviesRentalAPI.HelperEntities;
using MoviesRentalAPI.Models;
using MoviesRentalAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesRentalRepository _moviesRentalRepository;
        private readonly IMapper _mapper;

        public MoviesController(IMoviesRentalRepository moviesRentalRepository,
                IMapper mapper)
        {
            _moviesRentalRepository = moviesRentalRepository ??
                throw new ArgumentNullException(nameof(moviesRentalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        //not able to map the result to appropriate type

        [HttpGet]
        public async Task<IActionResult> GetAllMoviesWithGenreAndAvailability()
        {
            var movies = await _moviesRentalRepository.GetAllMoviesWithGenreAndAvailabilityAsync();


            return Ok(_mapper.Map<IEnumerable<CustomMovieDto>>(movies));
        }

        [HttpGet("avilablestocks/{movieId}")]
        public async Task<IActionResult> GetAvailableStocksForMovie(int movieId)
        {
            var movieFromRepo = await _moviesRentalRepository.MovieExists(movieId);
            if (!movieFromRepo)
            {
                return NotFound();
            }
            var StocksUniqueKeys = await _moviesRentalRepository.GetAvailableStocksForMovieAsync(movieId);
            return Ok(StocksUniqueKeys);
        }

        [HttpGet("rentalhistory/{movieId}")]
        public async Task<IActionResult> GetRentalHistoryForMovie(int movieId)
        {
            var movieFromRepo = await _moviesRentalRepository.MovieExists(movieId);
            if (!movieFromRepo)
            {
                return NotFound();
            }

            var rentalhistory = await _moviesRentalRepository.GetMovieWithRentalHistoryAsync(movieId);
            return Ok(rentalhistory);
        }

        [HttpGet("rentalperdate/{movieId}")]
        public async Task<IActionResult> GetRentalPerDate(int movieId)
        {
            var movieFromRepo = await _moviesRentalRepository.MovieExists(movieId);
            if (!movieFromRepo)
            {
                return NotFound();
            }

            var rentals = await _moviesRentalRepository.GetAllRentalsPerDateForMovieAsync(movieId);
            return Ok(rentals);
        }
    }
}
