using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;

namespace Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicle(string license, Guid brandId, string model, Guid driverId) 
        {
            var v = new Vehicle()
            {
                License = license,
                BrandId = brandId,
                Model = model,
                DriverId = driverId
            };

            return v;
        }

        public static Vehicle CreateVehicle(string license, Brand brand, string model, Driver driver)
        {
            var v = new Vehicle()
            {
                License = license,
                Model = model
            };

            v.SetBrand(brand);
            v.SetDriver(driver);

            return v;
        }
    }
}
