using DrinkMixer.Lib.DTO;

namespace DrinkMixer.Lib.Service
{
    public interface IMixerService
    {
        public string GetRecipePrice(SearchRecipeParameter param);
    }
}
