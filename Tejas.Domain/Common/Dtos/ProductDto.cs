using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }

        public double Cost { get; set; }

        public IList<ProductImage> Images { get; set; }
    }
}
