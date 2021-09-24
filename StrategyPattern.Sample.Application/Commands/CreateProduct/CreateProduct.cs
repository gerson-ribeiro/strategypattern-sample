using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.Commands.CreateProduct
{
    public class CreateProduct
    {
        private readonly ProductDbContext _dbContext;

        public CreateProduct(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Product product)
        {
            _dbContext.Add(product);

            await _dbContext.SaveChangesAsync();
        }
    }
}
