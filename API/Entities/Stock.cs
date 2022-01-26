using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Entities
{
    public class Stock
    {
        public int Id { get; set; }

        public string UniqueKey { get; set; }

        public bool IsAvailable { get; set; }

        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        public ICollection<Rental> Rentals { get; set; } =
            new List<Rental>();
    }
}
