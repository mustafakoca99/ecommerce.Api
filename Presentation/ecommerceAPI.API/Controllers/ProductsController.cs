using ecommerceAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ecommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        /// <summary>
        /// test method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){ Id = Guid.NewGuid(), Name = "test", Price = 100, Stock = 5, CreatedDate =DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "test_2", Price = 100, Stock = 5, CreatedDate =DateTime.UtcNow },
                new(){ Id = Guid.NewGuid(), Name = "test_3", Price = 100, Stock = 5, CreatedDate =DateTime.UtcNow }
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
