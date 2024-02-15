using DrinkMixer.Lib.DTO;
using DrinkMixer.Lib.Service;

namespace DrinkMixer.Exec;

internal sealed class ExempleClient(
    IMixerService mixerService)
{
    public void Do(int call, string arg)
    {
        SearchRecipeParameter param = null;
        try
        {
            long id = (long)Convert.ToDouble(arg);
            param = new SearchRecipeParameter { Id = id };
        }
        catch
        {
            param = new SearchRecipeParameter { Name = arg };
        }

        try
        {
            Console.WriteLine($"CALL : {call} - GUID : {mixerService.Id} \r");

            Console.WriteLine($"Recette demandée : { arg } \r");
            string price = mixerService.GetRecipePrice(param);

            Console.WriteLine($"Prix : { price }\r");
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}