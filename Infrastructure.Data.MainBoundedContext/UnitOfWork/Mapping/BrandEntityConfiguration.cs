using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping
{
    class BrandEntityConfiguration
        :EntityTypeConfiguration<Brand>
    {
        public BrandEntityConfiguration()
        {
            //Configure keys and properties
            this.HasKey(c => c.Id);

            this.Property(c => c.Name)
                .HasMaxLength(150)
                .IsRequired();

            //Table mappings
            this.ToTable("Brands");
        }
    }
}
