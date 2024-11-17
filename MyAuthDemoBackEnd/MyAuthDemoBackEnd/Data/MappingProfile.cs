using AutoMapper;
using MyAuthDemoBackEnd.Models;
using MyAuthDemoBackEnd.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyAuthDemoBackEnd.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
