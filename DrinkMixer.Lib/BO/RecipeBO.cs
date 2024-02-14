using DrinkMixer.Exec.DAO;

namespace DrinkMixer.Lib.BO
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

        public virtual decimal SellPriceInEuro
        {
            get
            {
                return RowPriceInEuro + RowPriceInEuro * Data.Margin;
            }
        }

        public virtual string DisplayPriceInEuro
        {
            get
            {
                return string.Format("{0:N} euro", SellPriceInEuro);
            }
        }

        public RecipeBO()
        {

        }
    }
}
