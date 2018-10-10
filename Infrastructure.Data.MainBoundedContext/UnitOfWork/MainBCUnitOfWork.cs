using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleDriverAgg;
using Infrastructure.Data.MainBoundedContext.UnitOfWork.Mapping;
using Infrastructure.Data.Seedwork;

namespace Infrastructure.Data.MainBoundedContext.UnitOfWork
{
    public class MainBCUnitOfWork
        : DbContext, IQueryableUnitOfWork
    {
        #region IDbSet Members

        ///
        /// Brands
        ///
        private IDbSet<Brand> _brands;
        public IDbSet<Brand> Brands => _brands ?? (_brands = base.Set<Brand>());

        ///
        /// InfractionTypes
        ///
        private IDbSet<InfractionType> _infractionTypes;
        public IDbSet<InfractionType> InfractionTypes => _infractionTypes ?? (_infractionTypes = base.Set<InfractionType>());

        ///
        /// Vehicles
        ///
        private IDbSet<Vehicle> _vehicles;
        public IDbSet<Vehicle> Vehicles => _vehicles ?? (_vehicles = base.Set<Vehicle>());

        ///
        /// Drivers
        ///
        private IDbSet<Driver> _drivers;
        public IDbSet<Driver> Drivers => _drivers ?? (_drivers = base.Set<Driver>());

        ///
        /// Infractions
        ///
        private IDbSet<Infraction> _infractions;
        public IDbSet<Infraction> Infractions => _infractions ?? (_infractions = base.Set<Infraction>());

        ///
        /// VehicleDrivers
        ///
        private IDbSet<VehicleDriver> _vehiclesDrivers;
        public IDbSet<VehicleDriver> VehiclesDrivers => _vehiclesDrivers ?? (_vehiclesDrivers = base.Set<VehicleDriver>());

        #endregion



        #region IQueryableUnitOfWork Members

        public DbSet<TEntity> CreateSet<TEntity>()
            where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item)
            where TEntity : class
        {
            //attach and set as unchanged
            base.Entry<TEntity>(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item)
            where TEntity : class
        {
            //this operation also attach item in object state manager
            base.Entry<TEntity>(item).State = EntityState.Modified;
        }
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            //if it is not attached, attach original and set current values
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException dbex)
            {
                var errMsgs = new List<String>();
                foreach (var err in dbex.EntityValidationErrors)
                    foreach (var valErr in err.ValidationErrors)
                        errMsgs.Add(valErr.ErrorMessage);

                var result = "";
                foreach (var e in errMsgs)
                    result += e + Environment.NewLine;

                throw new Exception(result);

            }
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();

                    saveFailed = false;

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.ToList()
                              .ForEach(entry =>
                              {
                                  entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                              });

                }
            } while (saveFailed);

        }

        public void RollbackChanges()
        {
            // set all entities in change tracker 
            // as 'unchanged state'
            base.ChangeTracker.Entries()
                              .ToList()
                              .ForEach(entry => entry.State = EntityState.Unchanged);
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        #endregion



        #region DbContext Overrides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove unused conventions
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Dgt entities configuration 
            modelBuilder.Configurations.Add(new BrandEntityConfiguration());
            modelBuilder.Configurations.Add(new InfractionTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new DriverEntityConfiguration());
            modelBuilder.Configurations.Add(new VehicleEntityConfiguration()); 
            modelBuilder.Configurations.Add(new InfractionEntityConfiguration());
            modelBuilder.Configurations.Add(new VehicleDriverEntityConfiguration());
        }

        #endregion
    }
}
