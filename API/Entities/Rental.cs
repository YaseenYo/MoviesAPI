using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Entities
{
    public class Rental
    {
        public int Id { get; set; }
       
        public DateTime RentalDate { get; set; }

        public DateTime ReturnedDate { get; set; }

        public bool Status { get; set; }

        public Stock Stock { get; set; }
        public int StockId { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
