using FirstExcel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExcel.Platforms.GOODS
{
    abstract class Goods : Platform 
    {
        public string ProductType { get; private set; }

        public Goods(string productType)
        {
            ProductType = productType;
        }

        abstract public Product Create();
    }
}
