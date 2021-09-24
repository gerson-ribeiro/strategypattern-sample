using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Application.ApplyDiscount.Strategy;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount
{
    public class ApplyDiscountStrategy : IApplyDiscountStrategy
    {
        private readonly ProductDbContext _dbContext;
        private readonly IDiscountStrategy<Product, Product> _strategy;

        public ApplyDiscountStrategy(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
            _strategy = new BookDiscountStrategy();
        }

        public async Task<Product> Handler(int id)
        {
            Product product = _dbContext.Products.Find(id);

            var productDiscounted = await _strategy.Handler(product);

            return productDiscounted;
        }
    }
}
