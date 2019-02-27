using System;

namespace opgave2_5
{
    class Number
    {
        private readonly int _number;
        public Number(int number)
        {
            _number = number;
        }

        string OddOrEven { 
            get 
            {
                var even = _number % 2 == 0;

                if (even) return "even";
                else return "odd";
            }
        }

        public override string ToString()
        {
            return _number + " is " + OddOrEven;
        }
    }
}