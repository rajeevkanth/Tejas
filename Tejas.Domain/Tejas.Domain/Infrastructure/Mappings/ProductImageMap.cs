using System.Data.Entity.ModelConfiguration;
using Tejas.Domain.DomainModel;

namespace Tejas.Domain.Infrastructure.Mappings
{
    public class ProductImageMap : EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMap()
        {
            ToTable("ProductImage");

            HasRequired(p => p.Product);

        }
    }
}