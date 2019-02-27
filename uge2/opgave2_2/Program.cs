using System;

namespace opgave2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose if you wan't to convert Celcius to Fahrenheit (type CF)");
                Console.WriteLine("Or if you wan't to convert Fahrenheit to Celcius (type FC)");
                Console.WriteLine("Write Q to quit");

                var input = Console.ReadLine().ToUpper();
                if (input == "Q") return;

                Console.Clear();
                Console.WriteLine("Type the tempature");
            
                var inputNumber = Console.ReadLine();
                float.TryParse(inputNumber, out float resultNumber);
                switch(input) 
                {
                    case "CF":
                        Console.WriteLine($"{resultNumber} celsius is " + Tempature.CelciusToFahrenheit(resultNumber) + "F");

                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        break;

                    case "FC":
                        Console.WriteLine($"{resultNumber} fahrenheit is " + Tempature.FahrenheitToCelcius(resultNumber) + " celsius");

                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        break;

                    default: 
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("press enter to try again");
                        Console.ReadLine();
                        break;
                }
            } while (run);
        }
    }
}
