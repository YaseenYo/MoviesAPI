using Microsoft.EntityFrameworkCore;
using MoviesRentalAPI.DbContexts;
using MoviesRentalAPI.Entities;
using MoviesRentalAPI.HelperEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Services
{
    public class MoviesRentalRepository : IMoviesRentalRepository
    {
        private readonly MoviesRentalContext _context;
        public MoviesRentalRepository(MoviesRentalContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        //checkpoint
        public async Task<IEnumerable<object>> GetAllGenresWithMoviesCountAsync()
        {
            return await _context.Genres.Select(g => new
            {
                Genre = g.Name,
                MoviesCount = g.Movies.Count
            }).ToListAsync();
        }

        //two different senerios, can we just give the genreid, availability ? ,checkpoint
        public async Task<IEnumerable<CustomMovie>> GetAllMoviesWithGenreAndAvailabilityAsync()
        {
            return await _context.Movies.Select(m => new CustomMovie
            {
                Movie = m,
                Genre = m.Genre.Name,
                Availability = (m.Stocks.Where(x => x.IsAvailable == true).Count())> 0
            }).ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public void AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            _context.Customers.Add(customer);
        }

        public async Task<IEnumerable<object>> GetMovieWithRentalHistoryAsync(int movieId)
        {
             return await _context.Rentals.Where(r => r.Stock.MovieId == movieId)
                .Select(r => new 
                {
                    Id = r.CustomerId,
                    Customer = $"{r.Customer.FirstName} {r.Customer.LastName}",
                    RentalDate = r.RentalDate,
                    Status = r.Status
                }).ToListAsync();
        }

        public async Task<IEnumerable<object>> GetAllRentalsPerDateForMovieAsync(int movieId)
        {
               return await   (from rental in _context.Rentals
                          where rental.Stock.MovieId == movieId
                          group rental by rental.RentalDate into grouping
                          select new
                          {
                              Date = grouping.Key,
                              RentalCount = grouping.Count()
                          }).ToListAsync();
        }

        public void AddMovie(int genreId, Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            movie.GenreId = genreId;
            var movieStock = new Stock
            {
                IsAvailable = true
            };
            movie.Stocks.Add(movieStock);
            _context.Movies.Add(movie);
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }

        public async Task<Movie> GetMovieAsync(int genreId, int movieId)
        {
            return await _context.Movies
                    .Where(m => m.GenreId == genreId && m.Id ==  movieId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<string>> GetAvailableStocksForMovieAsync(int movieId)
        {
            var movie = await  _context.Movies.Include(m => m.Stocks).FirstOrDefaultAsync(m => m.Id == movieId);
            
            return movie.Stocks.Where(s => s.IsAvailable == true).Select(s => s.UniqueKey).ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
        }

        public void UpdateMovie(Movie movie)
        {
        }

        public async Task<bool> MovieExists(int movieId)
        {
            return await _context.Movies.AnyAsync(m => m.Id == movieId);
        }

        public async Task<bool> GenreExists(int genreId)
        {
            return await _context.Genres.AnyAsync(g => g.Id == genreId);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

    }
}
