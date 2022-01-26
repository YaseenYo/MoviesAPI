using Microsoft.EntityFrameworkCore;
using MoviesRentalAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.DbContexts
{
    public class MoviesRentalContext : DbContext
    {
        public MoviesRentalContext(DbContextOptions<MoviesRentalContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Comedy"
                },
                new Genre()
                {
                    Id = 2,
                    Name = "Drama"
                },
                new Genre()
                {
                    Id = 3,
                    Name = "Romance"
                },
                new Genre()
                {
                    Id = 4,
                    Name = "Action"
                },
                new Genre()
                {
                    Id = 5,
                    Name = "Horror"
                });

            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    Id = 1,
                    FirstName = "yaseen",
                    LastName = "Ahmed",
                    Email = "Yoyo@gmail.com",
                    UniqueKey = "yo12546785",
                    Mobile = 123456787,
                    DateOfBirth = new DateTime(2000, 08, 17),
                    RegistrationDate = new DateTime(2017,05,12)
                },
                new Customer()
                {
                    Id = 2,
                    FirstName = "Maaz",
                    LastName = "Ahmed",
                    Email = "Yoyo@gmail.com",
                    UniqueKey = "yo78945612",
                    Mobile = 123456787,
                    DateOfBirth = new DateTime(2000, 08, 17),
                    RegistrationDate = new DateTime(2017,05,12)
                },
                new Customer()
                {
                    Id = 3,
                    FirstName = "Muiz",
                    LastName = "Ahmed",
                    Email = "Yoyo@gmail.com",
                    UniqueKey = "yo74185296",
                    Mobile = 123456787,
                    DateOfBirth = new DateTime(2000, 08, 17),
                    RegistrationDate = new DateTime(2017,05,12)
                },
                new Customer()
                {
                    Id = 4,
                    FirstName = "Kaif",
                    LastName = "Ahmed",
                    Email = "Yoyo@gmail.com",
                    UniqueKey = "yo96852741",
                    Mobile = 123456787,
                    DateOfBirth = new DateTime(2000, 08, 17),
                    RegistrationDate = new DateTime(2017,05,12)
                },
                new Customer()
                {
                    Id = 5,
                    FirstName = "Faizan",
                    LastName = "Ahmed",
                    Email = "Yoyo@gmail.com",
                    UniqueKey = "yo14725896",
                    Mobile = 123456787,
                    DateOfBirth = new DateTime(2000, 08, 17),
                    RegistrationDate = new DateTime(2017,05,12)
                });

            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = 1,
                    Title = "Dil Ke Arman",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 2
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Kal Ho Na Ho",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.3",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 2
                },new Movie()
                {
                    Id = 3,
                    Title = "Housefull 3",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.1",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 1
                },new Movie()
                {
                    Id = 4,
                    Title = "Bol Bachan",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.3",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 1
                },new Movie()
                {
                    Id = 5,
                    Title = "Don 3",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.9",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 4
                },new Movie()
                {
                    Id = 6,
                    Title = "Annabel",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.2",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 5
                },new Movie()
                {
                    Id = 7,
                    Title = "Dhoom 3",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.6",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 4
                },new Movie()
                {
                    Id = 8,
                    Title = "Jab Harry Met To Sejal",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.2",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 3
                },new Movie()
                {
                    Id = 9,
                    Title = "Ae Dil Hai Mushkil",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 3
                },new Movie()
                {
                    Id = 10,
                    Title = "Isssh Phir Koi Hai...",
                    Description = "It is one of the finest movies with full of drama and emotion",
                    Image = "image.png",
                    Director = "Kon hai Ki",
                    Writer = "Malum nai",
                    Producer = "Mere Paas Paisay nai Hein",
                    Rating = "4.4",
                    TrailerURI = "Youtube/trailers",
                    ReleaseDate = new DateTime(2017,12,25),
                    GenreId = 5
                });

            modelBuilder.Entity<Stock>().HasData(
                new Stock
                {
                    Id = 1,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 1
                },
                new Stock
                {
                    Id = 2,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 1
                },
                new Stock
                {
                    Id = 3,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 2
                },
                new Stock
                {
                    Id = 4,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 2
                },
                new Stock
                {
                    Id = 5,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 3
                },
                new Stock
                {
                    Id = 6,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 3
                },
                new Stock
                {
                    Id = 7,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 4
                },
                new Stock
                {
                    Id = 8,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 4
                },
                new Stock
                {
                    Id = 9,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 5
                },
                new Stock
                {
                    Id = 10,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 5
                },
                new Stock
                {
                    Id = 11,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 6
                },
                new Stock
                {
                    Id = 12,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 6
                },
                new Stock
                {
                    Id = 13,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 7
                },
                new Stock
                {
                    Id = 14,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 7
                },
                new Stock
                {
                    Id = 15,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 8
                },
                new Stock
                {
                    Id = 16,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 9
                },
                new Stock
                {
                    Id = 17,
                    UniqueKey = "124578yo",
                    IsAvailable = false,
                    MovieId = 10
                },
                new Stock
                {
                    Id = 18,
                    UniqueKey = "124578yo",
                    IsAvailable = true,
                    MovieId = 10
                });

            modelBuilder.Entity<Rental>().HasData(
                new Rental()
                {
                    Id = 1,
                    RentalDate = new DateTime(2018,02,26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 1,
                    CustomerId = 1
                },
                new Rental()
                {
                    Id = 2,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 3,
                    CustomerId = 4
                },
                new Rental()
                {
                    Id = 3,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 4,
                    CustomerId = 5
                },
                new Rental()
                {
                    Id = 4,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 8,
                    CustomerId = 3
                },
                new Rental()
                {
                    Id = 5,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 10,
                    CustomerId = 2
                },
                new Rental()
                {
                    Id = 6,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 12,
                    CustomerId = 1
                },
                new Rental()
                {
                    Id = 7,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 13,
                    CustomerId = 3
                },
                new Rental()
                {
                    Id = 8,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 15,
                    CustomerId = 2
                },
                new Rental()
                {
                    Id = 9,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 16,
                    CustomerId = 4
                },
                new Rental()
                {
                    Id = 10,
                    RentalDate = new DateTime(2018, 02, 26),
                    ReturnedDate = new DateTime(),
                    Status = true,
                    StockId = 17,
                    CustomerId = 5
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
