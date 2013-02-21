using System.Data.Entity.ModelConfiguration;
using Tejas.Domain.DomainModel;

namespace Tejas.Domain.Infrastructure.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            
        }
    }
}