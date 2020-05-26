using DickinsonBros.Guid.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DickinsonBros.Guid.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGuidService(this IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<IGuidService, GuidService>();
            return serviceCollection;
        }
    }
}
