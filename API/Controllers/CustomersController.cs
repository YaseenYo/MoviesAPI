using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MoviesRentalAPI.Entities;
using MoviesRentalAPI.Models;
using MoviesRentalAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MoviesRentalAPI.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly IMoviesRentalRepository _moviesRentalRepository;
        private readonly IMapper _mapper;

        public CustomersController(IMoviesRentalRepository moviesRentalRepository,
                IMapper mapper)
        {
            _moviesRentalRepository = moviesRentalRepository ??
                throw new ArgumentNullException(nameof(moviesRentalRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{customerId}",Name ="GetCustomer")]
        public async Task<IActionResult> GetCustomer(int customerId)
        {
            var customerFromRepo = await _moviesRentalRepository.GetCustomerAsync(customerId);

            if (customerFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CustomerDto>(customerFromRepo));
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customersFromRepo = await _moviesRentalRepository.GetCustomersAsync();

            return Ok(_mapper.Map<IEnumerable<CustomerDto>>(customersFromRepo));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCustomer(CustomerForCreationDto customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);
            _moviesRentalRepository.AddCustomer(customerEntity);
            await _moviesRentalRepository.SaveAsync();

            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);
            return CreatedAtRoute("GetCustomer",
                        new { customerId = customerToReturn.Id }, customerToReturn);
        }

        [HttpPatch("{customerId}")]
        [Authorize]
        public async Task<IActionResult> PartiallyUpdateCustomer(int customerId,
                            JsonPatchDocument<CustomerForUpdateDto> patchDocument)
        {
            var customerFromRepo = await _moviesRentalRepository.GetCustomerAsync(customerId);

            if (customerFromRepo == null)
            {
                return NotFound();
            }

            var customerToPatch = _mapper.Map<CustomerForUpdateDto>(customerFromRepo);

            patchDocument.ApplyTo(customerToPatch,ModelState);

            if (!TryValidateModel(customerToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(customerToPatch, customerFromRepo);

            _moviesRentalRepository.UpdateCustomer(customerFromRepo);

            await _moviesRentalRepository.SaveAsync();

            return NoContent();
        }
    }
}
