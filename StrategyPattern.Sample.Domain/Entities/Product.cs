using StrategyPattern.Sample.Domain.Products.Enums;

namespace StrategyPattern.Sample.Domain.Products.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Identification { get; set; }
        public ProductTypeEnum Type { get; set; }
        public double Price { get; set; }
    }
}
