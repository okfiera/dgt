using System.Web.Http;
using Infrastructure.CrossCutting.MainBoundedContext.IoC;
using Unity;
using Unity.WebApi;

namespace DistributedServices.MainBoundedContext.Api
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			//Register types
			IUnityContainer container = Container.BuildUnityContainer();

			//Configure factories
			Container.ConfigureFactories(container);

			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}
	}
}