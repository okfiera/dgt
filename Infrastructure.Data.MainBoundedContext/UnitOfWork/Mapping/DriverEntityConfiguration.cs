using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping
{
    class DriverEntityConfiguration
        :EntityTypeConfiguration<Driver>
    {
        public DriverEntityConfiguration()
        {
            //Configure keys and properties
            this.HasKey(c => c.Id);

            this.Property(c => c.Identifier)
                .HasMaxLength(20)
                .IsRequired();

            this.Property(c => c.FirstName)
                .HasMaxLength(150)
                .IsRequired();

            this.Property(c => c.LastName)
                .HasMaxLength(300)
                .IsRequired();

            this.Property(c => c.Points)
                .IsRequired();
        }
    }
}
