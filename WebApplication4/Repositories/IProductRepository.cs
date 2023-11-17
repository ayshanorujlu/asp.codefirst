using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
        Task AddRangeAsync(List<Product> products);
    }
}
