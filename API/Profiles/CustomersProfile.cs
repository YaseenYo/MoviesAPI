using AutoMapper;
using MoviesRentalAPI.Entities;
using MoviesRentalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalAPI.Profiles
{
    public class CustomersProfile: Profile
    {
        public CustomersProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Name,
                            opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            CreateMap<CustomerForCreationDto, Customer>();
            CreateMap<Customer, CustomerForUpdateDto>();
            CreateMap<CustomerForUpdateDto, Customer>();
                
        }
    }
}
