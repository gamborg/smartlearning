using System;

namespace opgave2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ratesService = new RateService();
            var euRate = ratesService.GetRate("EUR");

            var converter = new CurrencyService(euRate.Rate, 0);
            do
            {
                Console.Clear();
                Console.WriteLine(euRate);
                Console.WriteLine("\tOmregning mellem kroner og euro");
                Console.WriteLine("Valutavalg: Skriv 'DK' for Kroner eller 'EU' for Euro:\n");
                var input = Console.ReadLine().ToUpper();
                if (!(input == "DK" || input == "EU"))
                {
                    Console.WriteLine("Fortkert input, prøv igen.");
                    Console.WriteLine("Tryk på en vilkårlig tast for at prøve igen.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Indtast det ønskede beløb:\n");
                    var inputAmount = Console.ReadLine();
                    if (double.TryParse(inputAmount, out double amount))
                    {
                        converter.SetAmount(amount);
                        
                        string symbol = "EUR";
                        switch(input) {
                            case "DK": converter.Convert(); break;
                            case "EU": converter.Convert(false); symbol = "DKK"; break;
                        }

                        var convertet = converter.ConvertedAmount;
                        
                        Console.WriteLine($"\n\n{ amount.ToString("F2") } { input } svarer til { convertet.ToString("F2") } { symbol } ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Input skal være et tal.\n");
                        Console.WriteLine("Tryk en vilkårlig tast for at prøve igen.");
                        Console.ReadKey();
                    }

                }

            } while (true);
        }
    }
}
