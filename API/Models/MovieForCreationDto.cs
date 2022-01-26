﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Models
{
    public class MovieForCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Writer { get; set; }

        [Required]
        public string Producer { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public string TrailerURI { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
