using AutoMapper;
using HotelListing.Controllers.Data;
using HotelListing.Models;

namespace HotelListing.Configurations
{
    public class MapperInitializer : Profile
    {

        public MapperInitializer()
        {
            CreateMap<Country,CountryDTO>().ReverseMap();
            CreateMap<Country,CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel,HotelDTO>().ReverseMap();
            CreateMap<Hotel,CreateHotelDTO>().ReverseMap();

        }
    }
}
