namespace WinFormsApp1
{
    class CurrencyExchange
    {
        //private string fromCurrencyName;
        //private string toCurrencyName;

        private double exchangeRate;
        private double amountToExchange;

        public double GetExchangeRate()
        { 
            return exchangeRate;
        }
        public void SetExchangeRate(double rate)
        {
            if (rate > 0.0)
            {
                exchangeRate = rate;
            }
        }
        public double GetAmountToExchange()
        {
            return amountToExchange;
        }
        public void SetAmountToExchange(double value) 
        { 
            if (value > 0.0)
                amountToExchange = value;
        }
        public double CalculateNewAmount() 
        {
            double amount = 0.0;
            if (exchangeRate > 0.0)
                amount = amountToExchange / exchangeRate;

            return amount;
        }
    }
}
