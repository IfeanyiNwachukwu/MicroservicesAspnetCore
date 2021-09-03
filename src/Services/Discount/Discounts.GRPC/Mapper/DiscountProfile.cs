using AutoMapper;
using Discount.Grpc.Protos;
using Discounts.GRPC.Entities;


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
