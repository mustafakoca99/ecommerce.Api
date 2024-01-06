using ecommerceAPI.Domain.Entites.Common;

namespace ecommerceAPI.Domain.Entites
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
