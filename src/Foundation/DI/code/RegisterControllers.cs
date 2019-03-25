using Claro.Foundation.DI.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
namespace Claro.Foundation.DI
{
    public class RegisterControllers : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            // configurator per project? Use this:
            //serviceCollection.AddMvcControllersInCurrentAssembly();

            // configure all the things from on high by convention? Use this (Habitat as the example):
            serviceCollection.AddMvcControllers(
                "Claro.Feature.*");
        }
    }
}
