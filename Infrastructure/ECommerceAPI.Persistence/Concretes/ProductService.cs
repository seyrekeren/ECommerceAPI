using ECommerce.Domain.Entities;
using ECommerceAPI.Application.Abstractions;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new() { Id = Guid.NewGuid(), Price = 100, Name = "Product 1", Stock = 10},
                new() { Id = Guid.NewGuid(), Price = 200, Name = "Product 2", Stock = 10},
                new() { Id = Guid.NewGuid(), Price = 300, Name = "Product 3", Stock = 10},
                new() { Id = Guid.NewGuid(), Price = 400, Name = "Product 4", Stock = 10},
            };


    }
}
