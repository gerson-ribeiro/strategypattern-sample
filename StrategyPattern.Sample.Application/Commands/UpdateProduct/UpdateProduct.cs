using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.Commands.UpdateProduct
{
    public class UpdateProduct
    {
        private readonly ProductDbContext _dbContext;

        public UpdateProduct(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Update(Product product)
        {
            _dbContext.Update(product);

            await _dbContext.SaveChangesAsync();
        }
    }
}
