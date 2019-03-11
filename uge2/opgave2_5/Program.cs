using System;

namespace opgave2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            for (var i = 1; i <= 20; i++)
            {
                var n = new Number(i);
                Console.WriteLine(n);
            }

            Console.WriteLine("");
        }
    }
}
