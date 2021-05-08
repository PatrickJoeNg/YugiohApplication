using System;

namespace YugiohApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LifePointCalculator player1 = new LifePointCalculator()
            {
                Name = "Pat",
                DeckName = "Zefra"
            };
            LifePointCalculator player2 = new LifePointCalculator()
            {
                Name = "Brian",
                DeckName = "ABC"
            };

            Console.WriteLine("Welcome to Duel Interface!");


            while (true)
            {
                Console.WriteLine("Current Life Point State");

                Console.WriteLine("|Player 1|");
                player1.DisplayPlayerInfo();
                Console.WriteLine("");
                Console.WriteLine("|Player 2|");
                player2.DisplayPlayerInfo();

                Console.WriteLine("Choose your option.\n");
                Console.WriteLine("1 to Add Life Points, 2 to Subtract Life Points, 3 to Add turn counter");
                Console.WriteLine("Q to exit");

                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int value))
                {
                    if (value == 1)
                    {
                        Console.WriteLine(Choose you option);
                    }
                    Console.WriteLine("test");
                }
                if (userInput.ToUpper() == "Q")
                {
                    Console.WriteLine("Exiting Program...");
                    Console.ReadLine();
                    return;
                }
            }
           
        }
    }
}
