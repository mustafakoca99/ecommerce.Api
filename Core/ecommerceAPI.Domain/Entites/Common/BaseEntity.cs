namespace ecommerceAPI.Domain.Entites.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate  { get; set; }
    }
}
