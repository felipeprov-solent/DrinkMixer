namespace DrinkMixer.Lib.BO
{
    public class IngredientBO : BaseData
    {
        public string Name { get; set; }

        public decimal PricePerDose { get; set; }

        public CurrencyBO Currency { get; set; }

        public virtual decimal PricePerDoseInEuro
        {
            get
            {
                return PricePerDose * Currency.RateToEuro;
            }

        }

        public IngredientBO()
        {

        }
    }
}
