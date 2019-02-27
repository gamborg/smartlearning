using System;

namespace opgave2_1
{
    class CurrencyService
    {
        public double Rate { get; private set; }
        public double Amount { get; private set; }
        public double ConvertedAmount { get; private set; }

        public CurrencyService(double rate, double amount) 
        {
            Rate = rate;
            Amount = amount;
        }

        public CurrencyService(double rate)
        {
            Rate = rate;
        }

        public void SetAmount(double amount) 
        {
            Amount = amount;
        }
        public double Convert(bool toOtherCurrency = true) 
        {
            if (toOtherCurrency) 
            {
                ConvertedAmount = Amount / Rate;
            }
            else
            {
                ConvertedAmount = Amount * Rate;
            }
            
            return ConvertedAmount;
        }
    }
}