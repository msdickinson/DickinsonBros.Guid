using DickinsonBros.Guid.Abstractions;
using DickinsonBros.Guid.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DickinsonBros.Guid.Tests.Extensions
{
    [TestClass]
    public class IServiceCollectionExtensionsTests
    {
        [TestMethod]
        public void AddPropelAPI_Should_Succeed()
        {
            // Arrange
            var serviceCollection = new ServiceCollection();

            // Act
            serviceCollection.AddGuidService();

            // Assert
            Assert.IsTrue(serviceCollection.Any(serviceDefinition => serviceDefinition.ServiceType == typeof(IGuidService) &&
                                                       serviceDefinition.ImplementationType == typeof(GuidService) &&
                                                       serviceDefinition.Lifetime == ServiceLifetime.Singleton));
        }
    }
}
