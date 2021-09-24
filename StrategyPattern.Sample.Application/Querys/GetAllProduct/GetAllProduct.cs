using StrategyPattern.Sample.Domain.Products.Entities;
using Microsoft.EntityFrameworkCore;
using StrategyPattern.Sample.Products.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.Querys.GetAllProduct
{
    public class GetAllProduct
    {
        private readonly ProductDbContext _dbContext;

        public GetAllProduct(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetProducts()
            => await _dbContext.Products.ToListAsync();
    }
}
