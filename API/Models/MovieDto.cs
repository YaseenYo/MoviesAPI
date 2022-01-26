using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Producer { get; set; }
        public string Rating { get; set; }
        public string TrailerURI { get; set; }
        public DateTime ReleaseDate { get; set; }
        
    }
}
