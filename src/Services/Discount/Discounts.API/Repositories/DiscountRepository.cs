using Dapper;
using Discounts.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Threading.Tasks;

namespace Discounts.API.Repositories
{
    public class DiscountRepository : RepositoryBase<Coupon>,IDiscountRepository
    {
       
      
        public DiscountRepository(RepositoryContext context) :base(context)
        {
           
        }
        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            if(coupon != null)
            {
                Create(coupon);
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteDiscount(string productName,bool trackChanges)
        {
            var coupon = await GetDiscount(productName, trackChanges);
            if (coupon != null)
            {
                Delete(coupon);
                return true;
            }
            return false;
        }

        public async Task<Coupon> GetDiscount(string productName,bool trackChanges)
        {
           
            var discounts = await FindAll(trackChanges).ToListAsync();
            var discountByProductName = discounts.Find(d => d.ProductName.Equals(productName));
            return discountByProductName;
         }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            if (coupon != null)
            {
                Update(coupon);
                return true;
            }
            return  false;
            
        }
    }
}
