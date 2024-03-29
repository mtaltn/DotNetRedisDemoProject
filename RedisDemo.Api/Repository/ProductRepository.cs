﻿using Microsoft.EntityFrameworkCore;
using RedisDemo.Api.Models;
using RedisDemo.Api.Redis;

namespace RedisDemo.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetAsync()
        {
            return await _appDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            //return await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            return await _appDbContext.Products.FindAsync(id);
        }

    }
}
