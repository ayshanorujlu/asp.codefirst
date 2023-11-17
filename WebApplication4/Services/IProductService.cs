using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Entities;

namespace WebApplication4.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllByKey(string key = "");
    }
}
