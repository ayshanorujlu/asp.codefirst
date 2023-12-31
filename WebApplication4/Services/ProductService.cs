﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Entities;
using WebApplication4.Repositories;

namespace WebApplication4.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllByKey(string key = "")
        {
            var data = await _productRepository.GetAllAsync();
            return key != "" ? data.Where(s => s.Name.ToLower().Contains(key.ToLower())).ToList()
                : data;
        }
    }
}
