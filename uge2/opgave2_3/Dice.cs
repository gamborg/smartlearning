using System;

namespace opgave2_3
{
    public class Dice
    {
        private int _number;
        private int _numberOfSides;
        private int _numberOfThrows;

        public int CurrentVisibleNumber => _number;
        public int NumberOfThrows => _numberOfThrows;

        public Dice() 
        {
            _number = 1;
            _numberOfSides = 6;
        }

        public Dice(int initialNumber, int numberOfSides)
        {
            _number = initialNumber;
            _numberOfSides = numberOfSides;
        }

        public void ThrowDice() 
        {
            var random = new Random();
            _number = random.Next(1, _numberOfSides+1);
            _numberOfThrows++;
        }
    }
}