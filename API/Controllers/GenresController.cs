using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesRentalAPI.Models;
using MoviesRentalAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Controllers
{
    [ApiController]
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IMoviesRentalRepository _moviesRentalRepository;
        private readonly IMapper _mapper;

        public GenresController(IMoviesRentalRepository moviesRentalRepository,
                IMapper mapper)
        {
            _moviesRentalRepository = moviesRentalRepository ??
                throw new ArgumentNullException(nameof(moviesRentalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGenresWithMoviesCount()
        {
            var genresFromRepo = await _moviesRentalRepository.GetAllGenresWithMoviesCountAsync();
            return Ok(genresFromRepo);
        }
    }
}
