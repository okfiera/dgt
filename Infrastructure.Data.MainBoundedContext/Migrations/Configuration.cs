using Infrastructure.Data.MainBoundedContext.DgtModule.InitialData;

namespace Infrastructure.Data.MainBoundedContext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UnitOfWork.MainBCUnitOfWork>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(UnitOfWork.MainBCUnitOfWork context)
        {
            // Custom indexes
            //Create custom Indexes
            CustomIndexes.CreateCustomIndexes(context);

            //DgtModule entities
            InitialDataBrands.Seed(context);
            
            context.SaveChanges();
        }
    }
}
