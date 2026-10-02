/*
 * Student ID : 1690704141
 * Name       : จตุพล ใสยอด
 * Section    : 129B
 * No.        : 38
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Crystal";
            const double SmeltRate = 0.40;
            const double SalvageRate = 0.50;
            const int MaxBatch = 100;

            Console.WriteLine("----    Crystal Mine   ----");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine($"=> Key 'S' for Smelt (Ore -> {MaterialName} Ingot)");
            Console.WriteLine($"=> Key 'B' for Breakdown ({MaterialName} Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            char menuChar;

            if (!char.TryParse(menuInput, out menuChar))
            {
                Console.WriteLine("error: menu");
                return;
            }

            menuChar = char.ToUpper(menuChar);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            double amount;

            if (double.TryParse(amountInput, out amount) && amount > 0 && amount <= MaxBatch)
            {
                if (menuChar == 'S')
                {
                    double result = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot");
                }
                else if (menuChar == 'B')
                {
                    double result = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("error: menu");
                }
            }
            else
            {
                Console.WriteLine("error: amount");
            }


        }

     }

    }
