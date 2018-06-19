using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassLibrary1.Abstractions
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
