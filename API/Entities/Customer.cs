using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string UniqueKey { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int Mobile { get; set; }

        public DateTime RegistrationDate { get; set; }

        public ICollection<Rental> Rentals { get; set; } =
            new List<Rental>();
    }
}
