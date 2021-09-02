using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discounts.API.Repositories
{
    public interface IRepositoryManager
    {
        IDiscountRepository DiscountRepository { get; }
        Task SaveAsync();
    }
}
