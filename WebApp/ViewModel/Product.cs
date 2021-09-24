using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Identification { get; set; }
        public ProductTypeEnum Type { get; set; }
        public double Price { get; set; }
    }
}
