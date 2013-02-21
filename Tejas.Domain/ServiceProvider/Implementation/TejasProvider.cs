using System.Collections.Generic;
using Common;
using Contracts.Service;
using ServiceProvider.Interfaces;
using ServiceProvider.Provider;
using Tejas.Domain.DomainModel;
using Common.Dtos;

namespace ServiceProvider.Implementation
{
    public class TejasProvider : ProviderBase<ITejasService>,ITejasProvider
    {
        public void AddCustomer(CustomerDto customer)
        {
            Invoke(r => r.AddCustomer(customer));
        }

        public void AddOrder(OrderDto order)   
        {
            Invoke(r => r.AddOrder(order));
        }

        public void AddProduct(ProductDto product)
        {
            Invoke(r => r.AddProduct(product));
        }

        public IList<CustomerDto> GetAllCustomers()
        {
            return Invoke(r => r.GetAllCustomers());
        }

        public IList<CustomerDto> GetCustomer(CustomerSearchQuery searchQuery)
        {
            return Invoke(r => r.GetCustomer(searchQuery));
        }
    }
}