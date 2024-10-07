using System;
using BankKonsolApplikation.Konton;

namespace BankKonsolApplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("Välkommen till bankapplikationen!");

            while (true)
            {
                Console.WriteLine("\nVälj en åtgärd: 1. Visa saldo 2. Sätt in pengar 3. Ta ut pengar 4. Avsluta");
                string val = Console.ReadLine();

                try
                {
                    switch (val)
                    {
                        case "1":
                            // Visa saldo för alla konton
                            bank.VisaAllaKonton();
                            break;
                        case "2":
                            // Sätt in pengar till personkonto (exempel)
                            Console.Write("Ange belopp att sätta in på personkonto: ");
                            decimal insättning = decimal.Parse(Console.ReadLine());
                            bank.Personkonto.SättIn(insättning);
                            break;
                        case "3":
                            // Ta ut pengar från personkonto (exempel)
                            Console.Write("Ange belopp att ta ut från personkonto: ");
                            decimal uttag = decimal.Parse(Console.ReadLine());
                            bank.Personkonto.TaUt(uttag);
                            break;
                        case "4":
                            // Avsluta programmet
                            Console.WriteLine("Tack för att du använde bankapplikationen!");
                            return;
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fel: {ex.Message}");
                }
            }
        }
    }
}
