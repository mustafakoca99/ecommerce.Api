using ecommerceAPI.Domain.Entites.Common;

namespace ecommerceAPI.Domain.Entites
{
    public class Order: BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Descrition { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
