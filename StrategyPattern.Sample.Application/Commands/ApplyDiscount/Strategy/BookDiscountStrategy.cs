using StrategyPattern.Sample.Domain.Products.Entities;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount.Strategy
{
    public class BookDiscountStrategy : IDiscountStrategy<Product, Product>
    {
        public IDiscountStrategy<Product, Product> Next { get; set; }
        public BookDiscountStrategy()
        {
            Next = new MagazineDiscountStrategy();
        }

        public async Task<Product> Handler(Product product)
        {
            if(product.Type is not Domain.Products.Enums.ProductTypeEnum.Book)
            {
                return await Next.Handler(product);
            }

            // 3% de desconto para livros
            product.Price -= product.Price * 0.03;

            return product;
        }
    }
}
