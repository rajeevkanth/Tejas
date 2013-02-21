using System.Collections.Generic;
using Common;
using Tejas.Domain.DomainModel;
using Common.Dtos;

namespace ServiceProvider.Interfaces
{
    public interface ITejasProvider
    {
        void AddCustomer(CustomerDto customer);

        void AddOrder(OrderDto order);

        void AddProduct(ProductDto product);

        IList<CustomerDto> GetAllCustomers();

        IList<CustomerDto> GetCustomer(CustomerSearchQuery searchQuery);    
    }
}