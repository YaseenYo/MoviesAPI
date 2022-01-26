using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesRentalAPI.Services;

namespace API.Controllers
{
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly IMoviesRentalRepository _moviesRentalRepository;

        public TestController(IMoviesRentalRepository moviesRentalRepository)
        {
            _moviesRentalRepository = moviesRentalRepository ??
                throw new ArgumentNullException(nameof(moviesRentalRepository));
        }

        [HttpGet]
        public IActionResult GetAllGenresWithMoviesCount()
        {
            return Ok("Hello Brother...");
        }

    }
}