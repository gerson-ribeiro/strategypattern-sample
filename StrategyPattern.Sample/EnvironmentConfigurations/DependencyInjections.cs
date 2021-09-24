using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.Sample.Products.Application.ApplyDiscount;
using StrategyPattern.Sample.Products.Application.ProductFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Common.EnvironmentConfigurations
{
    public static class DependencyInjections
    {
        public static IServiceCollection ConfigureDI(this IServiceCollection services)
        {
            services.AddTransient<IProductFactory, ProductFactory>();
            services.AddTransient<IApplyDiscountStrategy, ApplyDiscountStrategy>();

            return services;
        }
    }
}
