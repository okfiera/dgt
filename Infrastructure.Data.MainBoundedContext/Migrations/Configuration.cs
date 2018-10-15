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

            //DgtModule entities
            InitialDataBrands.Seed(context);
            InitialDataDrivers.Seed(context);
            InitialDataInfractionTypes.Seed(context);
            InitialDataVehicles.Seed(context);
            InitialDataInfractions.Seed(context);


            //// Custom indexes
            CustomIndexes.CreateCustomIndexes(context);

            context.SaveChanges();
        }
    }
}
