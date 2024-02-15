using DrinkMixer.Data.DAO;

namespace DrinkMixer.Data.BO
{
    public class RecipeBO : BaseData
    {
        public string Name { get; set; }

        private ICollection<RecipeStepBO> _recipeSteps;
        public virtual ICollection<RecipeStepBO> RecipeSteps
        {
            get
            {
                if (_recipeSteps == null)
                {
                    _recipeSteps = new List<RecipeStepBO>();
                }
                return _recipeSteps;
            }
            set
            {
                _recipeSteps = value;
            }
        }

        public virtual decimal RowPriceInEuro
        {
            get
            {
                decimal price = 0m;
                foreach (RecipeStepBO step in RecipeSteps)
                {
                    price += step.Dose * step.Ingredient.PricePerDoseInEuro;
                }
                return price;
            }
        }

        public RecipeBO()
        {

        }

        public decimal GetSellPriceInEuro(decimal margin)
        {
           return RowPriceInEuro + RowPriceInEuro * margin;
        }

        public string GetDisplayPriceInEuro(decimal margin)
        {
            
            return string.Format("{0:N} euro", GetSellPriceInEuro(margin));
        }
    }
}
