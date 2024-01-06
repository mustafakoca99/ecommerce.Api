using ecommerceAPI.Domain.Entites.Common;

namespace ecommerceAPI.Domain.Entites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
