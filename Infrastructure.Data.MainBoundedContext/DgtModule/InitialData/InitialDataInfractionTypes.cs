using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.InitialData
{
    public static class InitialDataInfractionTypes
    {
        public static void Seed(UnitOfWork.MainBCUnitOfWork context)
        {
            var excesoVelocidad20 = new InfractionType() { Name = "Exceder la velocidad máxima permitida en un 20%", Points = 2, CreatedDate = DateTime.Now };
            excesoVelocidad20.ChangeCurrentIdentity(EntityGuids.InfractionTypes.ExcesoVelocidad20);
            context.InfractionTypes.AddOrUpdate(excesoVelocidad20);

            var excesoVelocidad40 = new InfractionType() { Name = "Exceder la velocidad máxima permitida en un 40%", Points = 4, CreatedDate = DateTime.Now };
            excesoVelocidad40.ChangeCurrentIdentity(EntityGuids.InfractionTypes.ExcesoVelocidad40);
            context.InfractionTypes.AddOrUpdate(excesoVelocidad40);

            var excesoVelocidad60 = new InfractionType() { Name = "Exceder la velocidad máxima permitida en un 60%", Points = 8, CreatedDate = DateTime.Now };
            excesoVelocidad60.ChangeCurrentIdentity(EntityGuids.InfractionTypes.ExcesoVelocidad60);
            context.InfractionTypes.AddOrUpdate(excesoVelocidad60);

            var aparcarEnDobleFila = new InfractionType() { Name = "Aparcar en doble fila", Points = 2, CreatedDate = DateTime.Now };
            aparcarEnDobleFila.ChangeCurrentIdentity(EntityGuids.InfractionTypes.DobleFila);
            context.InfractionTypes.AddOrUpdate(aparcarEnDobleFila);

            var sinCinturonSeguridad = new InfractionType() { Name = "No llevar el cinturón de seguridad", Points = 3, CreatedDate = DateTime.Now };
            sinCinturonSeguridad.ChangeCurrentIdentity(EntityGuids.InfractionTypes.SinCinturonSeguridad);
            context.InfractionTypes.AddOrUpdate(sinCinturonSeguridad);
        }
    }
}
