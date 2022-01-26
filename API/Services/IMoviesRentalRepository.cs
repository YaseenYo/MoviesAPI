using MoviesRentalAPI.Entities;
using MoviesRentalAPI.HelperEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Services
{
    public interface IMoviesRentalRepository
    {
        Task<IEnumerable<object>> GetAllGenresWithMoviesCountAsync();
        Task<IEnumerable<CustomMovie>> GetAllMoviesWithGenreAndAvailabilityAsync();
        Task<IEnumerable<string>> GetAvailableStocksForMovieAsync(int movieId);
        Task<IEnumerable<object>> GetMovieWithRentalHistoryAsync(int movieId);
        Task<IEnumerable<object>> GetAllRentalsPerDateForMovieAsync(int movieId);
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerAsync(int customerId);
        void AddCustomer(Customer customer);
        void AddMovie(int genreId, Movie movie);
        Task<Movie> GetMovieAsync(int genreId, int movieId);
        void UpdateMovie(Movie movie);
        void UpdateCustomer(Customer customer);
        Task<bool> MovieExists(int movieId);
        Task<bool> GenreExists(int genreId);
        Task<bool> SaveAsync();

    }
}
