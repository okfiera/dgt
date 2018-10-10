using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping
{
    class VehicleDriverEntityConfiguration
        :EntityTypeConfiguration<VehicleDriver>
    {
        public VehicleDriverEntityConfiguration()
        {
            //Configure keys and properties
            this.HasKey(c => c.Id);

            this.Property(c => c.VehicleId)
                .IsRequired();

            this.Property(c => c.DriverId)
                .IsRequired();

            //Configure table associations
            this.HasRequired(c => c.Vehicle)
                .WithMany()
                .HasForeignKey(c => c.VehicleId)
                .WillCascadeOnDelete(false);

            this.HasRequired(c => c.Driver)
                .WithMany()
                .HasForeignKey(c => c.DriverId)
                .WillCascadeOnDelete(false);

            //Configure table mappings
            this.ToTable("VehiclesDrivers");
        }
    }
}
