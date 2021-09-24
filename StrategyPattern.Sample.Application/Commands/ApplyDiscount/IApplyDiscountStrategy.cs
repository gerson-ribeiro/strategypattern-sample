using StrategyPattern.Sample.Domain.Products.Entities;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount
{
    public interface IApplyDiscountStrategy
    {
        Task<Product> Handler(int id);
    }
}