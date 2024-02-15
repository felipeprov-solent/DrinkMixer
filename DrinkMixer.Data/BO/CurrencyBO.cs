namespace DrinkMixer.Data.BO
{
    public class CurrencyBO : BaseData
    {
        public string Name { get; set; }

        public string Tag { get; set; }

        public decimal RateToEuro { get; set; }

        public CurrencyBO()
        {

        }
    }
}
