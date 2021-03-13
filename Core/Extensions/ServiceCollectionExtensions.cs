using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection, Utilities.IoC.ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);

            }
            return Utilities.IoC.ServiceTool.Create(serviceCollection);
        }
    }
}
