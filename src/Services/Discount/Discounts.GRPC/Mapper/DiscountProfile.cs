using AutoMapper;
using Discounts.GRPC.Entities;
using Discounts.GRPC.Protos;

namespace Discounts.GRPC.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
