using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using System.Data.Entity.Migrations;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.InitialData
{
    public class InitialDataVehicles
    {
        public static void Seed(UnitOfWork.MainBCUnitOfWork context)
        {
            var ferrariGTO = new Vehicle() { BrandId = EntityGuids.Brands.FerrariBrandId, Model = "GTO", License="1234-ABC", CreatedDate = DateTime.Now };
            ferrariGTO.ChangeCurrentIdentity(EntityGuids.Vehicles.FerrariGTO);
            context.Vehicles.AddOrUpdate(ferrariGTO);

            var iagoAspas_Ferrari = new VehicleDriver() {DriverId = EntityGuids.Drivers.IagoAspas, VehicleId = EntityGuids.Vehicles.FerrariGTO, CreatedDate = DateTime.Now};
            iagoAspas_Ferrari.GenerateNewIdentity();
            context.VehiclesDrivers.Add(iagoAspas_Ferrari);




            var bmwM3 = new Vehicle() { BrandId = EntityGuids.Brands.BMWBrandId, Model = "M3", License = "4546-BBF", CreatedDate = DateTime.Now };
            bmwM3.ChangeCurrentIdentity(EntityGuids.Vehicles.BmwM3);
            context.Vehicles.AddOrUpdate(bmwM3);

            var nemanjaRadoja_BMW = new VehicleDriver() { DriverId = EntityGuids.Drivers.NemanjaRadoja, VehicleId = EntityGuids.Vehicles.BmwM3, CreatedDate = DateTime.Now };
            nemanjaRadoja_BMW.GenerateNewIdentity();
            context.VehiclesDrivers.Add(nemanjaRadoja_BMW);





            var seatLeon = new Vehicle() { BrandId = EntityGuids.Brands.SeatBrandId, Model = "Leon", License = "66547-AC", CreatedDate = DateTime.Now };
            seatLeon.ChangeCurrentIdentity(EntityGuids.Vehicles.SeatLeon);
            context.Vehicles.AddOrUpdate(seatLeon);

            var seatLeon_FranBeltran = new VehicleDriver() { DriverId = EntityGuids.Drivers.FranBeltran, VehicleId = EntityGuids.Vehicles.SeatLeon, CreatedDate = DateTime.Now };
            seatLeon_FranBeltran.GenerateNewIdentity();
            context.VehiclesDrivers.Add(seatLeon_FranBeltran);

            var iagoAspas_SeatLeon = new VehicleDriver() { DriverId = EntityGuids.Drivers.IagoAspas, VehicleId = EntityGuids.Vehicles.SeatLeon, CreatedDate = DateTime.Now };
            iagoAspas_SeatLeon.GenerateNewIdentity();
            context.VehiclesDrivers.Add(iagoAspas_SeatLeon);
        }
    }
}
