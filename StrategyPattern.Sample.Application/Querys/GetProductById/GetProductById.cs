using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.GetProductById
{
    public class GetProductById
    {
        private readonly ProductDbContext _dbContext;

        public GetProductById(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetById(int id) 
            => await _dbContext.Products.FindAsync(id);
    }
}
