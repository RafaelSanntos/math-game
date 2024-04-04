namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string userName, DateTime date)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Hello {userName}. It's {date}. This is your math's game. That's great that you're working on improving yourself. Press any key to display the main menu.\n");
            Console.ReadLine();

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Chose from the options below:
                    A - Addition
                    S - Subtraction
                    M - Multiplication
                    D - Division
                    H - Games History
                    Q - Quit the program");
                Console.WriteLine("------------------------------------------------------");

                string gameSelected = Console.ReadLine().Trim().ToLower();

                switch (gameSelected)
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;

                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;

                    case "m":
                        gameEngine.MutiplicationGame("Multiplication game");
                        break;

                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;

                    case "h":
                        Helpers.GetGamesHistory();
                        break;

                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("invalid Input");
                        Environment.Exit(1);
                        break;
                }
            } while (true);
        }
    }
}
