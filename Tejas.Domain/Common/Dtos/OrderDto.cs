using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public CustomerDto Customer { get; set; }

        public IList<ProductDto> Products { get; set; }
    }
}
