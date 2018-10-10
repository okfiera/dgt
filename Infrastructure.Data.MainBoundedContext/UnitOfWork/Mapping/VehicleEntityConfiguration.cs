using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping
{
    class VehicleEntityConfiguration
        :EntityTypeConfiguration<Vehicle>
    {
        public VehicleEntityConfiguration()
        {
            //Configure keys and properties
            this.HasKey(c => c.Id);

            this.Property(c => c.License)
                .HasMaxLength(10)
                .IsRequired();

            this.Property(c => c.BrandId)
                .IsRequired();

            this.Property(c => c.Model)
                .HasMaxLength(50)
                .IsRequired();

            //Configure table associations
            this.HasRequired(c => c.Brand)
                .WithMany()
                .HasForeignKey(c => c.BrandId)
                .WillCascadeOnDelete(false);

            //Configure table mappings
            this.ToTable("Vehicles");
        }
    }
}
