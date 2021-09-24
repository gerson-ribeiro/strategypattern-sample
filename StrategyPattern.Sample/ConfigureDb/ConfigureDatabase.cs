using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.Sample.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Sample.Common.ConfigureDb
{
    public static class ConfigureDatabase
    {
        public static IServiceCollection ConfigureDB(this IServiceCollection service)
        {
            service.AddDbContext<ProductDbContext>(opt => opt.UseInMemoryDatabase(nameof(ProductDbContext)));

            return service;
        }
    }
}
