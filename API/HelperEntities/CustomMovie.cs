using MoviesRentalAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.HelperEntities
{
    public class CustomMovie
    {
        public Movie Movie { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }
    }
}
