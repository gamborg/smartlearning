using System;

namespace opgave2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start rolling dice!");
            Console.ReadLine();

            var dice = new Dice(1, 6);
            int current = 0;
            Console.Clear();
            do
            {
                dice.ThrowDice();
                current = dice.CurrentVisibleNumber;
                var numberOfThrows = dice.NumberOfThrows;

                Console.WriteLine($"Current throw was a {current}, and we have rolled the dice {numberOfThrows} times");
            } while (current != 6);

            Console.WriteLine("You got a 6");
            Console.WriteLine("Hit enter to end program");
            Console.ReadLine();
        }
    }
}
