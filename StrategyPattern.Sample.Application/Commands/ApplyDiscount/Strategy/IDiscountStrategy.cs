using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Products.Application.ApplyDiscount.Strategy
{
    public interface IDiscountStrategy<TResponse,TResult>
    {
        IDiscountStrategy<TResponse,TResult> Next { get; set; }
        Task<TResult> Handler(TResponse product);
    }
}
