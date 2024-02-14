namespace DrinkMixer.BO
{
    public class RecipeStepBO : BaseData
    {
        public RecipeBO Recipe { get; set; }

        public int Order { get; set; }

        public int Dose { get; set; }

        public IngredientBO Ingredient { get; set; }

        public RecipeStepBO()
        {

        }
    }
}
