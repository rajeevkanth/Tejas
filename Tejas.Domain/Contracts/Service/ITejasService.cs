using System.Collections.Generic;
using System.ServiceModel;
using Common;
using Tejas.Domain.DomainModel;

namespace Contracts.Service
{
    [ServiceContract]
    public interface ITejasService
    {
        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract]
        void AddOrder(Order order);

        [OperationContract]
        void AddProduct(Product product);

        [OperationContract]
        IList<Customer> GetAllCustomers();

        [OperationContract]
        IList<Customer> GetCustomer(CustomerSearchQuery searchQuery);    
    }
}