using System.Collections.Generic;
using System.ServiceModel;
using Common;
using Contracts.Service;
using Tejas.Domain.DomainContext;
using Tejas.Domain.DomainModel;
using System.Linq;
using Common.Dtos;
using Tejas.Domain.Infrastructure.Extensions;

namespace TejasService.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TejasService :ITejasService
    {
        private readonly ITejasContext _context = new TejasContext(); 

        public void AddCustomer(CustomerDto customer)
        {
            _context.AddCustomer(customer.ToDomain());
            _context.SaveChanges();
        }

        public void AddOrder(OrderDto order)
        {
            _context.AddOrder(order.ToDomain());
            _context.SaveChanges();
        }

        public void AddProduct(ProductDto product)
        {
            _context.AddProduct(product.ToDomain());
            _context.SaveChanges();
        }

        public IList<CustomerDto> GetAllCustomers()
        {
            return _context.Customers.ToArray().Select(p=>p.ToDto()).ToList();
        }

        public IList<CustomerDto> GetCustomer(CustomerSearchQuery searchQuery)
        {
            return _context.Customers.Where(c => c.Name.Contains(searchQuery.Name)).ToArray().Select(p=>p.ToDto()).ToList();
        }
    }
}