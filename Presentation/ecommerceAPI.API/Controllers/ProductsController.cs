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
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, ILogger<ProductsController> logger)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task Get()
        {
            _logger.LogInformation("start get product");

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
