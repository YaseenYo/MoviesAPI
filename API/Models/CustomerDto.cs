using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UniqueKey { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Mobile { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
