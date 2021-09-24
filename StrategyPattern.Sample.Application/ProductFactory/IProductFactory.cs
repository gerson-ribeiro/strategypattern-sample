using StrategyPattern.Sample.Products.Application.Commands.DeleteProduct;
using StrategyPattern.Sample.Products.Application.Commands.CreateProduct;
using StrategyPattern.Sample.Products.Application.Commands.UpdateProduct;
using StrategyPattern.Sample.Products.Application.Querys.GetAllProduct;
using StrategyPattern.Sample.Products.Application.ApplyDiscount;

namespace StrategyPattern.Sample.Products.Application.ProductFactory
{
    public interface IProductFactory
    {
        CreateProduct CreateProduct { get; }
        DeleteProduct DeleteProduct { get; }
        GetAllProduct GetAllProduct { get; }
        GetProductById.GetProductById ProductById { get; }
        UpdateProduct UpdateProduct { get; }

        IApplyDiscountStrategy ApplyDiscount { get; }
    }
}