using System.Collections.Generic;
using System.ServiceModel;
using Common;
using Tejas.Domain.DomainModel;
using Common.Dtos;

namespace Contracts.Service
{
    [ServiceContract]
    public interface ITejasService
    {
        [OperationContract]
        void AddCustomer(CustomerDto customer);

        [OperationContract]
        void AddOrder(OrderDto order);

        [OperationContract]
        void AddProduct(ProductDto product);

        [OperationContract]
        IList<CustomerDto> GetAllCustomers();

        [OperationContract]
        IList<CustomerDto> GetCustomer(CustomerSearchQuery searchQuery);    
    }
}