using DickinsonBros.Guid.Abstractions;
using System.Diagnostics.CodeAnalysis;

namespace DickinsonBros.Guid
{
    [ExcludeFromCodeCoverage]
    public class GuidService : IGuidService
    {
        public System.Guid NewGuid()
        {
            return System.Guid.NewGuid();
        }
    }
}
