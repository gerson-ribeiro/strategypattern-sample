using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.Commands.DeleteProduct
{
    public class DeleteProduct
    {
        private readonly ProductDbContext _dbContext;

        public DeleteProduct(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Delete(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Remove(product);

            await _dbContext.SaveChangesAsync();
        }
    }
}
