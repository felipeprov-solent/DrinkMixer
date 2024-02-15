using Microsoft.Extensions.DependencyInjection;

namespace DrinkMixer.Lib.Service
{
    public interface IServiceLifetime
    {
        Guid Id { get; }
    }
}
