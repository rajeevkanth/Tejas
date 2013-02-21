using Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tejas.Domain.DomainModel;

namespace Tejas.Domain.Infrastructure.Extensions
{
    public static class DtoToDomainMapping
    {

        public static Customer ToDomain(this CustomerDto dto)
        {
            return new Customer
            {
                Id = dto.CustomerId,
                Name = dto.Name,
                Address = dto.Address,

            };
        }


        public static Order ToDomain(this OrderDto dto)
        {
            return new Order
            {
                Id = dto.OrderId,
                Customer = dto.Customer.ToDomain()
            };
        }

        public static Product ToDomain(this ProductDto dto)
        {
            return new Product
            {
                Name = dto.Name,
                Cost = dto.Cost
            };
        }

        public static CustomerDto ToDto(this Customer customer)
        {
            return new CustomerDto
            {
                CustomerId = customer.Id,
                Name = customer.Name,
                Address = customer.Address,
            };
        }

    }
}
