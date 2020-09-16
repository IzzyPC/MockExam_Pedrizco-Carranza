using System;

namespace MockExam_Pedrizco_Carranza
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfChoice = new string[3];
            listOfChoice[0] = "1.";
            listOfChoice[1] = "2.";
            listOfChoice[2] = "3.";

            int[] listOfChoiceChosen = new int[3];
            listOfChoiceChosen[0] = 1;
            listOfChoiceChosen[1] = 2;
            listOfChoiceChosen[2] = 3;

            const double PRICE_OF_PUZZLE_GAMES = 19.95;
            int numberOfPuzzleGames;
            double totalPriceOfPuzzleGames;
            int chosenOption;
            int amountOfGamePurchased;
            int amountOfGameSold;
            int currentAmountOfGame;

            Console.WriteLine("*** Welcome to the Puzzle Hunters store! ***");
            Console.Write("Enter the number of the puzzle games currently in the store: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int.TryParse(Console.ReadLine(), out numberOfPuzzleGames);
            Console.ResetColor();

            totalPriceOfPuzzleGames = numberOfPuzzleGames * PRICE_OF_PUZZLE_GAMES;

            Console.WriteLine($"{listOfChoice[0]} Purchase puzzle games from the customers" +
                $"\n{listOfChoice[1]} Sell puzzle games to the customers" +
                $"\n{listOfChoice[2]} Display the current value of the inventory");
            Console.Write("Select one of the options: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int.TryParse(Console.ReadLine(), out chosenOption);
            Console.ResetColor();

            //List of options that user chose
            if (chosenOption == listOfChoiceChosen[0])
            {
                //If purchasing, amount of games will lose, but the owner will gain some currency values.
                Console.Write("How many puzzle games would you like to purchase: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int.TryParse(Console.ReadLine(), out amountOfGamePurchased);
                Console.ResetColor();
                currentAmountOfGame = numberOfPuzzleGames - amountOfGamePurchased;
                totalPriceOfPuzzleGames =  totalPriceOfPuzzleGames + (amountOfGamePurchased * PRICE_OF_PUZZLE_GAMES);

                Console.WriteLine("Puzzle Games Inventory Valuation\n");
                Console.WriteLine($"Current number of puzzle games in the store - {currentAmountOfGame}" +
                    $"\nCurrent value - {totalPriceOfPuzzleGames:C}");
            }
            else if (chosenOption == listOfChoiceChosen[1])
            {
                //It is the opposite of purchase...
                Console.Write("How many puzzle games would you like to sell: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int.TryParse(Console.ReadLine(), out amountOfGameSold);
                Console.ResetColor();
                currentAmountOfGame = numberOfPuzzleGames - amountOfGameSold;
                totalPriceOfPuzzleGames = totalPriceOfPuzzleGames + (amountOfGameSold * PRICE_OF_PUZZLE_GAMES);

                Console.WriteLine("Puzzle Games Inventory Valuation\n");
                Console.WriteLine($"Current number of puzzle games in the store - {currentAmountOfGame}" +
                    $"\nCurrent value - {totalPriceOfPuzzleGames:C}");
            }
            else if (chosenOption == listOfChoiceChosen[2])
            {
                Console.WriteLine("Puzzle Games Inventory Valuation\n");
                Console.WriteLine($"Current number of puzzle games in the store - {numberOfPuzzleGames}" +
                    $"\nCurrent value - {totalPriceOfPuzzleGames:C}");
            }
        }
    }
}
