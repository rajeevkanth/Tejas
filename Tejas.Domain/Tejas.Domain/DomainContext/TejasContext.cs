using System.Collections.Generic;
using System.Linq;
using Common;
using Tejas.Domain.DomainModel;
using Tejas.Domain.Infrastructure;
using System.Data.Entity;
using Tejas.Domain.Infrastructure.Mappings;

namespace Tejas.Domain.DomainContext
{
    public class TejasContext:DbContextBase , ITejasContext
    {
        public IList<Customer> Customers { get; set; }

        public IList<Order> Orders { get; set; }

        public IList<Product> Products { get;set; }

        
        public void AddCustomer(Customer customer)
        {
            
        }

        public void AddOrder(Order order)
        {
            
        }

        public void AddProduct(Product product)
        {
            
        }

        public IList<Customer> GetAllCustomers()
        {
            return Customers;
        }

        public IList<Customer> GetCustomer(CustomerSearchQuery searchQuery)
        {
            return Customers.Where(c => c.Name.Contains(searchQuery.Name)).ToList();
        }

        public new bool SaveChanges()
        {
            base.SaveChanges();
            return true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
        }
    }
}