using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount.Strategy
{
    public class MagazineDiscountStrategy : IDiscountStrategy<Product, Product>
    {
        public IDiscountStrategy<Product, Product> Next { get; set; }

        public MagazineDiscountStrategy()
        {
            Next = new ComicDiscountStrategy();
        }

        public async Task<Product> Handler(Product product)
        {
            if (product.Type is not Domain.Products.Enums.ProductTypeEnum.Magazine)
            {
                return await Next.Handler(product);
            }
            // 10% de desconto para Revistas
            product.Price -= product.Price * 0.1;
            return product;
        }
    }
}
