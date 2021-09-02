using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discounts.API.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private  RepositoryContext _context;
        private  IDiscountRepository _discountRepository;
        public RepositoryManager(RepositoryContext cOntext)
        {
            _context = cOntext;
        }

        public IDiscountRepository DiscountRepository
        {
            get
            {
                if (_discountRepository == null)
                {
                    _discountRepository = new DiscountRepository(_context);
                }

                return _discountRepository;
            }
        }

        public Task SaveAsync() => _context.SaveChangesAsync();


    }
}
