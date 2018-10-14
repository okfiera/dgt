using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using System.Data.Entity.Migrations;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.InitialData
{
    public static class InitialDataDrivers
    {
        public static void Seed(UnitOfWork.MainBCUnitOfWork context)
        {
            var iagoAspas = new Driver() { FirstName = "Iago", LastName = "Aspas", Identifier = "0000000A", CreatedDate = DateTime.Now};
            iagoAspas.ChangeCurrentIdentity(EntityGuids.Drivers.IagoAspas);
            context.Drivers.AddOrUpdate(iagoAspas);

            var nemanjaRadoja = new Driver() { FirstName = "Nemanja", LastName = "Radoja", Identifier = "11111111B", CreatedDate = DateTime.Now };
            nemanjaRadoja.ChangeCurrentIdentity(EntityGuids.Drivers.NemanjaRadoja);
            context.Drivers.AddOrUpdate(nemanjaRadoja);

            var franBeltran = new Driver() { FirstName = "Fran", LastName = "Beltrán", Identifier = "2222222C", CreatedDate = DateTime.Now };
            franBeltran.ChangeCurrentIdentity(EntityGuids.Drivers.FranBeltran);
            context.Drivers.AddOrUpdate(franBeltran);
        }
    }
}
