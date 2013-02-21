using System.Data.Entity.ModelConfiguration;
using Tejas.Domain.DomainModel;

namespace Tejas.Domain.Infrastructure.Mappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Order");
            HasRequired(o => o.Customer).WithMany(o => o.Orders).HasForeignKey(o => o.CustomerId);
        }
    }
}