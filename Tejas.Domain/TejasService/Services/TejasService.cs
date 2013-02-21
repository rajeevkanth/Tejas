using System.Collections.Generic;
using System.ServiceModel;
using Common;
using Contracts.Service;
using Tejas.Domain.DomainContext;
using Tejas.Domain.DomainModel;
using System.Linq;

namespace TejasService.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TejasService :ITejasService
    {
        private readonly ITejasContext _context = new TejasContext(); 

        public void AddCustomer(Customer customer)
        {
            _context.AddCustomer(customer);
            _context.SaveChanges();
        }

        public void AddOrder(Order order)
        {
            _context.AddOrder(order);
            _context.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            _context.AddProduct(product);
            _context.SaveChanges();
        }

        public IList<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }

        public IList<Customer> GetCustomer(CustomerSearchQuery searchQuery)
        {
            return _context.Customers.Where(c => c.Name.Contains(searchQuery.Name)).ToList();
        }
    }
}