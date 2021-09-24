using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount.Strategy
{
    public class NoOpStrategy : IDiscountStrategy<Product, Product>
    {
        public IDiscountStrategy<Product, Product> Next { get; set; }

        public Task<Product> Handler(Product product)
        {
            return Task.FromResult(product);
        }
    }
}
