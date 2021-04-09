using AutoMapper;
using HotelListing.Data;
using HotelListing.DTOs;

namespace HotelListing.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, CountryCreateDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<ApiUsers, UserDto>().ReverseMap();
        }
    }
}