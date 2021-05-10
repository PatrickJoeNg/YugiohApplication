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
                Console.WriteLine("1 to Add Life Points, 2 to Subtract Life Points");
                Console.WriteLine("Q to exit");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int value))
                {
                    ////////////////////////
                    // Adding Life points //
                    ////////////////////////
                    ////////////////////////
                    if (value == 1)
                    {
                        Console.WriteLine("Choose your option");

                        Console.WriteLine("1 to add custom amount, 2 to add 1000");
                        string choice = Console.ReadLine();
                        if (int.TryParse(choice, out int choiceVal))
                        {

                            // Adding Custom amount //
                            //////////////////////////
                            if (choiceVal == 1)
                            {
                                // Choose player to add to //
                                /////////////////////////////

                                Console.WriteLine("Whose Life Points? (1 for player1, 2 for player 2)");
                                string playerInput = Console.ReadLine();
                                if (int.TryParse(playerInput, out int playerNum))
                                {
                                    // Player 1
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
                                    //Player 2
                                    if (playerNum == 2)
                                    {
                                        Console.WriteLine("Type the amount to Add");
                                        string lpAmount = Console.ReadLine();

                                        if (int.TryParse(lpAmount, out int amount))
                                        {
                                            Console.WriteLine("Adding " + amount + " to " + player2.Name + "'s life points.\n");
                                            player2.AddCustomAmount(amount);
                                        }
                                    }
                                }
                            }
                            /////////////////////
                            // Adding set 1000 //
                            /////////////////////
                            if (choiceVal == 2)
                            {
                                Console.WriteLine("Whose Life Points? (1 for player1, 2 for player 2)");
                                string playerInput = Console.ReadLine();

                                if (int.TryParse(playerInput, out int playerNum))
                                {
                                    if (playerNum == 1)
                                    {
                                        Console.WriteLine("Adding 1000 to " + player1.Name + "'s life points.\n");
                                        player1.AddThousandLPs();
                                    }
                                    if (playerNum == 2)
                                    {
                                        Console.WriteLine("Adding 1000 to " + player2.Name + "'s life points.\n");
                                        player2.AddThousandLPs();
                                    }
                                }
                            }
                        }

                    }
                    /////////////////////////////
                    // Subtracting life points //
                    /////////////////////////////
                    /////////////////////////////
                    ///
                    if (value == 2)
                    {
                        // option for taking a 1000 or 800 (common choices in yugioh)
                        Console.WriteLine("Choose your option");
                        Console.WriteLine("1 to take 1000, 2 to take 800, 3 for custom amount");
                        userInput = Console.ReadLine();

                        if (int.TryParse(userInput, out value))
                        {
                            // Taking 1000 lift points
                            if (value == 1)
                            {
                                Console.WriteLine("Which player? (1 for player1 -- 2 for player2)");
                                string playerInput = Console.ReadLine();

                                if (int.TryParse(playerInput, out int playerNum))
                                {
                                    if (playerNum == 1)
                                    {
                                        Console.WriteLine("Taking 1000 LPs");
                                        player1.SubThousandLPs();
                                    }
                                    if (playerNum == 2)
                                    {
                                        Console.WriteLine("Taking 1000 LPs");
                                        player2.SubThousandLPs();
                                    }
                                }
                            }
                            // Taking 800 points
                            if (value == 2)
                            {
                                Console.WriteLine("Which player? (1 for player1 -- 2 for player2)");
                                string playerInput = Console.ReadLine();

                                if (int.TryParse(playerInput, out int playerNum))
                                {
                                    if (playerNum == 1)
                                    {
                                        Console.WriteLine("Taking 800 LPs");
                                        player1.SubEight();
                                    }
                                    if (playerNum == 2)
                                    {
                                        Console.WriteLine("Taking 800 LPs");
                                        player2.SubEight();
                                    }
                                }
                            }

                            ///////////////////////////
                            // Setting Custom Amount //
                            ///////////////////////////   
                            if (value == 3)
                            {

                                // Choose player to add to //
                                /////////////////////////////

                                Console.WriteLine("Whose Life Points? (1 for player1, 2 for player 2)");
                                string playerInput = Console.ReadLine();
                                if (int.TryParse(playerInput, out int playerNum))
                                {
                                    // Player 1
                                    if (playerNum == 1)
                                    {
                                        Console.WriteLine("Type the amount to sub");
                                        string lpAmount = Console.ReadLine();

                                        if (int.TryParse(lpAmount, out int amount))
                                        {
                                            Console.WriteLine("Taking " + amount + " from " + player1.Name + "'s life points.\n");
                                            player1.SubCustomAmount(amount);
                                        }
                                    }
                                    //Player 2
                                    if (playerNum == 2)
                                    {
                                        Console.WriteLine("Type the amount to sub");
                                        string lpAmount = Console.ReadLine();

                                        if (int.TryParse(lpAmount, out int amount))
                                        {
                                            Console.WriteLine("Taking " + amount + " from " + player2.Name + "'s life points.\n");
                                            player2.SubCustomAmount(amount);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // Quit Functionality //
                ////////////////////////
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
