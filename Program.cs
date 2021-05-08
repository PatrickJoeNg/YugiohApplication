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
                Console.WriteLine("----Current Life Point State----");

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
                        Console.WriteLine("Choose your option");
                        Console.WriteLine("1 to add custom amount, 2 to add 1000");
                        userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out value))
                        {
                            if (value == 1)
                            {
                                Console.WriteLine("Whose Life Points? (1 for player1, 2 for player 2)");
                                string playerInput = Console.ReadLine();
                                if (int.TryParse(playerInput, out int playerNum))
                                {
                                    if (playerNum == 1)
                                    {
                                        Console.WriteLine("Type the amount to Add");
                                        string lpAmount = Console.ReadLine();

                                        if (int.TryParse(lpAmount, out int amount))
                                        {
                                            Console.WriteLine("Adding " + amount + " to " + player1.Name + "'s life points.\n");
                                            player1.AddCustomAmount(amount);
                                        }
                                    }
                                    if (playerNum == 2)
                                    {
                                        Console.WriteLine("Type the amount to Add");
                                        string lpAmount = Console.ReadLine();

                                        if (int.TryParse(lpAmount, out int amount))
                                        {

                                        }
                                    }
                                   
                                }
                                else
                                {
                                    Console.WriteLine("Input either 1 or 2");
                                }
                                
                                
                            }
                        }

                    }
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
