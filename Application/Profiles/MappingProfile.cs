using Application.DTOs.Car;
using Application.DTOs.Location;
using Application.DTOs.User;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Car, GetAvailableCarDto>()
                .ReverseMap();
            CreateMap<Car, GetCarDto>()
                .ReverseMap();
            CreateMap<Car,RentCarDto>()
                .ReverseMap();
            CreateMap<Car, ReturnCarDto>()
                .ReverseMap();
            CreateMap<Car, UpdateCarDto>()
                .ReverseMap();

            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<Location, CreateLocationDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
        }
    }
}
