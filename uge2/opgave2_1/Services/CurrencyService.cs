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
            Rate = rate / 100;
            Amount = amount;
        }

        public CurrencyService(double rate)
        {
            Rate = rate / 100;
        }

        public void SetAmount(double amount) 
        {
            Amount = amount;
        }
        public double Convert(bool toLocal = true) 
        {
            if (toLocal) 
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