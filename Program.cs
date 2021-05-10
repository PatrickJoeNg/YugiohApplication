using System;

namespace YugiohApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two player objects

            LifePointCalculator player1 = new LifePointCalculator()
            {
                Name = "",
                DeckName = ""
            };
            LifePointCalculator player2 = new LifePointCalculator()
            {
                Name = "",
                DeckName = ""
            };

            InitGame(player1, player2);

            // start program
            Console.WriteLine("\nWelcome to Duel Interface!");

            while (true)
            {

                Console.WriteLine("----Current Life Point State----\n");

                Console.WriteLine("|Player 1|");
                player1.DisplayPlayerInfo();
                Console.WriteLine("");
                Console.WriteLine("|Player 2|");
                player2.DisplayPlayerInfo();


                Console.WriteLine("Choose your option.\n");
                Console.WriteLine("1 to Add Life Points, 2 to Subtract Life Points, 3 for Dice Roll");
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
                        Console.WriteLine("\nChoose your option");

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

                    //////////////////
                    /// Dice Roll ////
                    if (value ==3 )
                    {
                        Console.WriteLine("Who is rolling dice? (1 for player1, 2 for player2)");
                        string choice = Console.ReadLine();
                        if (int.TryParse(choice, out int choiceVal))
                        {
                            if (choiceVal == 1 )
                            {
                                Console.WriteLine($"{player1.Name} is going for a dice roll!");
                                Console.WriteLine($"\nDice roll is {player1.GetDiceRoll()} ");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                            }
                            if (choiceVal == 2)
                            {
                                Console.WriteLine($"{player2.Name} is going for a dice roll!");
                                Console.WriteLine($"\nDice roll is {player2.GetDiceRoll()} ");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
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

        private static void InitGame(LifePointCalculator player1, LifePointCalculator player2)
        {
            // param for initalization
            bool init = true;

            //loop create player details
            while (init)
            {
                //player 1 init
                Console.WriteLine("Please input player 1 name:");
                string playerOneName = Console.ReadLine();
                player1.Name = playerOneName;
                Console.WriteLine("\nPlease input player1's deck name:");
                string pOneDeckName = Console.ReadLine();
                player1.DeckName = pOneDeckName;


                //player 2 init
                Console.WriteLine("\nPlease input player 2 name:");
                string playerTwoName = Console.ReadLine();
                player2.Name = playerTwoName;
                Console.WriteLine("\nPlease input player2's deck name:");
                string pTwoDeckName = Console.ReadLine();
                player2.DeckName = pTwoDeckName;

                init = false;
            }
        }

    }
}
