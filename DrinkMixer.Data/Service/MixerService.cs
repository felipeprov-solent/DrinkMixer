﻿using DrinkMixer.Data.BO;
using DrinkMixer.Lib.DTO;
using DrinkMixer.Lib.Service;

namespace DrinkMixer.Data.Service
{
    public class MixerService : IMixerService
    {
        Guid IServiceLifetime.Id { get; } = Guid.NewGuid();

        public MixerService()
        {

        }

        public string GetRecipePrice(SearchRecipeParameter param)
        {          
            RecipeBO recipe = null;

            if (param.Id != null)
            {
                recipe = DAO.Data.Recipes.SingleOrDefault(r => r.Id == param.Id.Value);
            }
            else if (param.Name != null)
            {
                IList<RecipeBO> matchingRecipeName = DAO.Data.Recipes.Where(r => r.Name == param.Name).ToList();
                if (matchingRecipeName.Any())
                {
                    if (matchingRecipeName.Count > 1)
                    {
                        throw new Exception("Plusieures recette ont le même nom");
                    }
                    recipe = matchingRecipeName.Single();
                }
            }
            else
            {
                throw new Exception("Aucun paramètre fourni");
            }

            if (recipe == null)
            {
                throw new Exception("Aucune recette correspondante trouvée");
            }

            return recipe.GetDisplayPriceInEuro(DAO.Data.Parameter.Margin);
        }
    }
}
