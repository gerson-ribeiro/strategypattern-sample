using StrategyPattern.Sample.Products.Application.Commands.DeleteProduct;
using StrategyPattern.Sample.Products.Application.Commands.CreateProduct;
using StrategyPattern.Sample.Products.Application.Commands.UpdateProduct;
using StrategyPattern.Sample.Products.Application.Querys.GetAllProduct;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Sample.Products.Application.ApplyDiscount;

namespace StrategyPattern.Sample.Products.Application.ProductFactory
{
    public class ProductFactory : IProductFactory
    {
        private readonly ProductDbContext _dbContext;
        public IApplyDiscountStrategy ApplyDiscount { get; set; }

        public ProductFactory(ProductDbContext dbContext, IApplyDiscountStrategy applyDiscount)
        {
            _dbContext = dbContext;
            ApplyDiscount = applyDiscount;
        }

        public CreateProduct CreateProduct => new CreateProduct(_dbContext);
        public DeleteProduct DeleteProduct => new DeleteProduct(_dbContext);
        public UpdateProduct UpdateProduct => new UpdateProduct(_dbContext);

        public GetProductById.GetProductById ProductById => new GetProductById.GetProductById(_dbContext);
        public GetAllProduct GetAllProduct => new GetAllProduct(_dbContext);
    }
}
