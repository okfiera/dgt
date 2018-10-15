using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.InitialData
{
    public class InitialDataInfractions
    {
        public static void Seed(UnitOfWork.MainBCUnitOfWork context)
        {
            var infraction1 = InfractionFactory.CreateInfraction(EntityGuids.Vehicles.FerrariGTO,
                EntityGuids.InfractionTypes.ExcesoVelocidad20, EntityGuids.Drivers.IagoAspas, DateTime.Now);
            infraction1.CreatedDate = DateTime.Now;
            infraction1.GenerateNewIdentity();
            context.Infractions.AddOrUpdate(infraction1);

            var infraction2 = InfractionFactory.CreateInfraction(EntityGuids.Vehicles.SeatLeon,
                EntityGuids.InfractionTypes.DobleFila, EntityGuids.Drivers.FranBeltran, DateTime.Now);
            infraction2.CreatedDate = DateTime.Now;
            infraction2.GenerateNewIdentity();
            context.Infractions.AddOrUpdate(infraction2);

            var infraction3 = InfractionFactory.CreateInfraction(EntityGuids.Vehicles.BmwM3,
                EntityGuids.InfractionTypes.SinCinturonSeguridad, EntityGuids.Drivers.NemanjaRadoja, DateTime.Now);
            infraction3.CreatedDate = DateTime.Now;
            infraction3.GenerateNewIdentity();
            context.Infractions.AddOrUpdate(infraction3);
        }
    }
}
