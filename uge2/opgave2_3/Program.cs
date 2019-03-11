using System;
using System.Collections.Generic;

namespace opgave2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start rolling dice!");
            Console.ReadLine();

            var list = new List<Dice>();

            for (var i = 1; i < 20; i++)
            {
                list.Add(new Dice(1, 6));
            }

            //var dice = new Dice(1, 6);
            int current = 0;
            Console.Clear();
            do
            {
                Console.Write("Current roll: ");
                foreach (var dice in list)
                {
                    dice.Roll();
                    Console.Write($"\t{dice.CurrentVisibleNumber}");
                }
                Console.WriteLine("");
                //dice.Roll();
                //current = dice.CurrentVisibleNumber;
                //var numberOfThrows = dice.NumberOfThrows;
                //Console.WriteLine($"Current throw was a {current}, and we have rolled the dice {numberOfThrows} times");
                current++;
            } while (current != 6);

            Console.WriteLine("You got a 6");
            Console.WriteLine("Hit enter to end program");
            Console.ReadLine();
        }
    }
}
