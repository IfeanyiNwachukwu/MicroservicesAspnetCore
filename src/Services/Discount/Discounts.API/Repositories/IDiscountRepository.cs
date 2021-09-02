using Discounts.API.Entities;
using System.Threading.Tasks;

namespace Discounts.API.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName, bool trackChanges);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName, bool trackChanges);
    }
}
