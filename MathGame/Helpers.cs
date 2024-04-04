namespace MathGame
{
    internal class Helpers
    {
        static List<string> gamesHistory = new();
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 9);
            var secondNumber = 0;

            do
            {
                secondNumber = random.Next(1, 9); // Garante que o segundo número seja diferente de zero
            } while (firstNumber % secondNumber != 0);

            var result = new int[] { firstNumber, secondNumber };

            return result;
        }

        internal static void GetGamesHistory()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------------------------------------");

            foreach (var game in gamesHistory)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }

        internal static  void AddToHistory(int gameScore, string gameType)
        {
            gamesHistory.Add($"{DateTime.Now} - {gameType}: Score= {gameScore}");
        }
    }
}
