using System.Collections.Generic;
using Common;
using Contracts.Service;
using Tejas.Domain.DomainContext;
using Tejas.Domain.DomainModel;

namespace Services
{
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
            return _context.GetAllCustomers();
        }

        public IList<Customer> GetCustomer(CustomerSearchQuery searchQuery)
        {
            return _context.GetCustomer(searchQuery);
        }
    }
}