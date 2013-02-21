using System.Collections.Generic;
using Common;
using Tejas.Domain.DomainModel;

namespace ServiceProvider.Interfaces
{
    public interface ITejasProvider
    {
        void AddCustomer(Customer customer);

        void AddOrder(Order order);

        void AddProduct(Product product);

        IList<Customer> GetAllCustomers();

        IList<Customer> GetCustomer(CustomerSearchQuery searchQuery);    
    }
}