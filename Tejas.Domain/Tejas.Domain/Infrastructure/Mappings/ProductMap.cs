using System.Data.Entity.ModelConfiguration;
using Tejas.Domain.DomainModel;

namespace Tejas.Domain.Infrastructure.Mappings
{
public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasOptional(p => p.Images);
        }    
    }
}