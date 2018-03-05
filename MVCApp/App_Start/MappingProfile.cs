using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MVCApp.Models;
using MVCApp.Dtos;

namespace MVCApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                            .ForMember(c => c.ID, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                            .ForMember(c => c.ID, opt => opt.Ignore());
        }
    }
}