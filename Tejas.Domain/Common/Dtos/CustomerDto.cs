using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public IList<OrderDto> Orders { get; set; }

        
    }
}
