using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Claro.Foundation.Content.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Claro.Foundation.Content.DI
{
    public class RegisterContainer: IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IContentRepository, ContentRepository>();
            serviceCollection.AddTransient<IRenderingRepository, RenderingRepository>();
            serviceCollection.AddTransient<IContextRepository, ContextRepository>();
        }
    }
}