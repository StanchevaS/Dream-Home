using AutoMapper;
using DreamHome.Models;
using DreamHome.Services.Models;

namespace DreamHome.MapperProfiles
{
    public class BookingMapperProfile : Profile
    {
        public BookingMapperProfile()
        {
            CreateMap<CreateBookingVIewModel, CreateBookingDto>();
        }
    }
}