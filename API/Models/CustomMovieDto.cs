using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Models
{
    public class CustomMovieDto
    {
        public MovieDto Movie { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }
    }
}
