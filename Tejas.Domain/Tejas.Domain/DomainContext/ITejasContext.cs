using System.Collections.Generic;
using Common;
using Tejas.Domain.DomainModel;

namespace Tejas.Domain.DomainContext
{
    public interface ITejasContext 
    {
        IList<Customer> Customers { get; }

        IList<Order> Orders { get; }

        IList<Product> Products { get; }

        void AddCustomer(Customer customer);

        void AddOrder(Order order);

        void AddProduct(Product product);

        IList<Customer> GetAllCustomers();

        IList<Customer> GetCustomer(CustomerSearchQuery searchQuery);

        bool SaveChanges();
    }
}
