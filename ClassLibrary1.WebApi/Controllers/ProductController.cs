using System.Threading.Tasks;
using ClassLibrary1.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ClassLibrary1.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetProducts();
            return Ok(result);
        }
    }
}