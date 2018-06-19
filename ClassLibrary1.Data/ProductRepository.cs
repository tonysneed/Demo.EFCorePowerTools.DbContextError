using System.Collections.Generic;
using System.Threading.Tasks;
using ClassLibrary1.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindSlimContext _context;

        public ProductRepository(NorthwindSlimContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }
    }
}