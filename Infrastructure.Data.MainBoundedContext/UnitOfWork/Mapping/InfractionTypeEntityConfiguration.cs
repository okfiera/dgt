using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping
{
    class InfractionTypeEntityConfiguration
        :EntityTypeConfiguration<InfractionType>
    {
        public InfractionTypeEntityConfiguration()
        {
            //Configure keys and properties
            this.HasKey(c => c.Id);

            this.Property(c => c.Name)
                .HasMaxLength(150)
                .IsRequired();

            this.Property(c => c.Points)
                .IsRequired();

            this.Property(c => c.Description)
                .HasMaxLength(500)
                .IsOptional();

            //Table mappings
            this.ToTable("InfractionTypes");
        }
    }
}
