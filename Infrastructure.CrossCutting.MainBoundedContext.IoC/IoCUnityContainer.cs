using Application.MainBoundedContext.Services;
using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using Domain.MainBoundedContext.DgtModule.Aggregates.DriverAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.InfractionTypeAg;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;
using Infrastructure.Crosscutting.Adapter;
using Infrastructure.Crosscutting.Logging;
using Infrastructure.Crosscutting.NetFramework.Adapter;
using Infrastructure.Crosscutting.NetFramework.Caching;
using Infrastructure.Crosscutting.NetFramework.Logging;
using Infrastructure.Crosscutting.NetFramework.Validator;
using Infrastructure.Crosscutting.Validator;
using Infrastructure.Data.MainBoundedContext.DgtModule.Repositories;
using Unity;
using Unity.Lifetime;

namespace Infrastructure.CrossCutting.MainBoundedContext.IoC
{
    public static class Container
    {
        #region Members

        private static IUnityContainer _container;

        #endregion


        #region Properties

        /// <summary>
        /// Get the current configured container
        /// </summary>
        /// <returns>Configured container</returns>
        public static IUnityContainer Current
        {
            get
            {
                if (_container == null)
                    _container = BuildUnityContainer();

                return _container;
            }
        }

        #endregion


        #region Public methods

        public static IUnityContainer BuildUnityContainer()
        {
            // Take into account that Types and Mappings registration could be also done using the UNITY XML configuration
            //But we prefer doing it here (C# code) because we'll catch errors at compiling time instead execution time, 
            //if any type has been written wrong.

            _container = new UnityContainer();

            //-> Unit of Work and repositories
            //container.RegisterType<IMainBCUnitOfWork, MainBCUnitOfWork>(new PerResolveLifetimeManager());
            // _container.RegisterType(typeof(MainBCUnitOfWork), new PerResolveLifetimeManager());

            //
            //-> ADAPTERS ---------------------------------------------------------------------------------------------------------------------------
            //
            _container.RegisterType<ITypeAdapterFactory, AutomapperTypeAdapterFactory>(new ContainerControlledLifetimeManager());

            //
            //-> CACHE MANAGERS ----------------------------------------------------------------------------------------------------------
            _container.RegisterType<Crosscutting.Caching.ICacheManager, CacheManager>();


            //
            //-> REPOSITORIES -----------------------------------------------------------------------------------------------------------------------
            //
            // -> CommonModule
            _container.RegisterType<IBrandRepository, BrandRepository>();
            _container.RegisterType<IInfractionTypeRepository, InfractionTypeRepository>();
            _container.RegisterType<IDriverRepository, DriverRepository>();
            _container.RegisterType<IInfractionRepository, InfractionRepository>();
            _container.RegisterType<IVehicleRepository, VehicleRepository>();


            //
            //-> DOMAIN SERVICES  ----------------------------------------------------------------------------------------------------------------
            //

            //
            //-> APPLICATION SERVICES ----------------------------------------------------------------------------------------------------------
            //
            // -> CommonModule
            _container.RegisterType<IDgtAppService, DgtAppService>();



            //Return container
            return _container;
        }

        public static void ConfigureFactories(IUnityContainer container)
        {
            LoggerFactory.SetCurrent(new TraceSourceLogFactory());
            EntityValidatorFactory.SetCurrent(new DataAnnotationsEntityValidatorFactory());

            var typeAdapterFactory = container.Resolve<ITypeAdapterFactory>();
            TypeAdapterFactory.SetCurrent(typeAdapterFactory);
        }

        #endregion
    }
}
