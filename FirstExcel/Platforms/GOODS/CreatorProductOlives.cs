using FirstExcel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExcel.Platforms.GOODS
{
    class CreatorProductOlives : Goods
    {
        public CreatorProductOlives(string productType) : base(productType)
        { }

        public override Product Create()
        {
            return new ProductOlives();
        }
    }
}
