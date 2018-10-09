using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping
{
    class InfractionEntityConfiguration
        :EntityTypeConfiguration<Infraction>
    {
        public InfractionEntityConfiguration()
        {
            //Configure keys and properties
            this.HasKey(c => c.Id);

            this.Property(c => c.DriverId)
                .IsRequired();
            
            this.Property(c => c.VehicleId)
                .IsRequired();

            this.Property(c => c.InfractionTypeId)
                .IsRequired();
            
            this.Property(c => c.Date)
                .IsRequired();


            // Configure table associations
            this.HasRequired(s => s.Driver)
                .WithMany()
                .HasForeignKey(s => s.DriverId)
                .WillCascadeOnDelete(true);

            this.HasRequired(s => s.Vehicle)
                .WithMany()
                .HasForeignKey(s => s.VehicleId)
                .WillCascadeOnDelete(true);

            this.HasRequired(s => s.InfractionType)
                .WithMany()
                .HasForeignKey(s => s.InfractionTypeId)
                .WillCascadeOnDelete(true);


            //Table mappings
            this.ToTable("Infractions");
        }
    }
}
