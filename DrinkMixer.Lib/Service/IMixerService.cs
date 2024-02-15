using DrinkMixer.Lib.DTO;
using Microsoft.Extensions.DependencyInjection;

namespace DrinkMixer.Lib.Service
{
    public interface IMixerService : IServiceLifetime
    {
        public string GetRecipePrice(SearchRecipeParameter param);
    }
}
