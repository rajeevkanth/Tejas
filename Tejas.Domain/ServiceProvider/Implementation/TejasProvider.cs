using System.Collections.Generic;
using Common;
using Contracts.Service;
using ServiceProvider.Interfaces;
using ServiceProvider.Provider;
using Tejas.Domain.DomainModel;

namespace ServiceProvider.Implementation
{
    public class TejasProvider : ProviderBase<ITejasService>,ITejasProvider
    {
        public void AddCustomer(Customer customer)
        {
            Invoke(r => r.AddCustomer(customer));
        }

        public void AddOrder(Order order)   
        {
            Invoke(r => r.AddOrder(order));
        }

        public void AddProduct(Product product)
        {
            Invoke(r => r.AddProduct(product));
        }

        public IList<Customer> GetAllCustomers()
        {
            return Invoke(r => r.GetAllCustomers());
        }

        public IList<Customer> GetCustomer(CustomerSearchQuery searchQuery)
        {
            return Invoke(r => r.GetCustomer(searchQuery));
        }
    }
}