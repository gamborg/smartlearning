using System;

namespace opgave2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (var i = 1; i <= 10; i++) 
            {
                var t = new Table(i);
                Console.WriteLine(t.Print(10));
            }

            Console.WriteLine();
        }
    }
}
