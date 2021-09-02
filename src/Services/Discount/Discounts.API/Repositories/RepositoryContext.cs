using Discounts.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Discounts.API.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }
    }
}
