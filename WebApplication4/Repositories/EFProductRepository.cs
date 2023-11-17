using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Entities;

namespace WebApplication4.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;

        public EFProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Product product)
        {
           await _dbContext.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<Product> products)
        {
            await _dbContext.AddRangeAsync(products);
            await _dbContext.SaveChangesAsync();
         
        }

        public async Task DeleteAsync(Product product)
        {
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
