using AutoMapper;
using CouponAPI.Models;
using CouponAPI.Models.Dto;

namespace CouponAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Define the mapping between Coupon and CouponDto
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
