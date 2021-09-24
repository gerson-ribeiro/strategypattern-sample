using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount.Strategy
{
    public class ComicDiscountStrategy: IDiscountStrategy<Product, Product>
    {
        public IDiscountStrategy<Product, Product> Next { get; set; }

        public ComicDiscountStrategy()
        {
            Next = new NoOpStrategy();
        }

        public async Task<Product> Handler(Product product)
        {
            if (product.Type is not Domain.Products.Enums.ProductTypeEnum.Comic)
            {
                return await Next.Handler(product);
            }

            // 22% de desconto para HQ's e Mangas
            product.Price -= product.Price * 0.22;

            return product;
        }
    }
}
