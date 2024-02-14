using DrinkMixer.DTO;
using DrinkMixer.Service;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            throw new Exception("Aucun argument fourni. Veuillez indiquer le nom ou l'id de votre boisson.");
        }

        SearchRecipeParameter param = null;
        try
        {
            long id = (long)Convert.ToDouble(args[0]);
            param = new SearchRecipeParameter { Id = id };
        }
        catch
        {
            param = new SearchRecipeParameter { Name = args[0] };
        }

        try
        {
            Console.WriteLine($"Recette demandée : {args[0]} \r");
            string price = MixerService.GetRecipePrice(param);

            Console.WriteLine($"Prix : {price}\r");
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }


        return;
    }
}