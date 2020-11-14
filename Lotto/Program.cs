using Lotto.Checker;
using Lotto.Selection;
using System;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var userSelection = new LottoSelection();
            var ballSelectionMessage = $"Enter {LottoSelection.BallCount} ball numbers between 1 and 50, separated by a comma, or simply press ENTER key for lucky dip";
            var powerBallSelectionMessage = $"Enter {LottoSelection.PowerBallCount} powerball numbers between 1 and 8, separated by a comma";

            Console.WriteLine(ballSelectionMessage);

            var firstInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstInput))
            {
                userSelection = LottoSelector.GenerateSelection();
                Console.WriteLine(userSelection);
            }
            else
            {
                var ballNumbers = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                while (!InputValidator.TryValidateInput(ballNumbers, LottoSelection.BallCount, 50, out string error))
                {
                    Console.WriteLine(error);
                    Console.WriteLine(ballSelectionMessage);
                    ballNumbers = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                }

                userSelection.Balls[0] = int.Parse(ballNumbers[0]);
                userSelection.Balls[1] = int.Parse(ballNumbers[1]);
                userSelection.Balls[2] = int.Parse(ballNumbers[2]);
                userSelection.Balls[3] = int.Parse(ballNumbers[3]);
                userSelection.Balls[4] = int.Parse(ballNumbers[4]);

                Console.WriteLine(powerBallSelectionMessage);

                var powerballNumbers = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

                while (!InputValidator.TryValidateInput(powerballNumbers, 2, 8, out string error))
                {
                    Console.WriteLine(error);
                    Console.WriteLine(powerBallSelectionMessage);
                    powerballNumbers = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                }

                userSelection.PowerBalls[0] = int.Parse(powerballNumbers[0]);
                userSelection.PowerBalls[1] = int.Parse(powerballNumbers[1]);

            }

            Console.WriteLine("Now enter the number of attempts you would like to try");
            var numOfTimes = Console.ReadLine().Trim();
            while (!int.TryParse(numOfTimes, out _))
            {
                Console.WriteLine("Please enter a whole number. Enter the number of attempts you would like to try");
                numOfTimes = Console.ReadLine();
            }
            var attempts = int.Parse(numOfTimes);

            var test = new ResultGenerator();
            var results = await test.GenerateResults(attempts);
            var win = LottoChecker.CheckResults(userSelection, results);
            
            var winString = win ? "won" : "didn't win";

            Console.WriteLine($"Out of {string.Format("{0:n0}", attempts)} attempts, you {winString} the jackpot.");

            var stats = StatsBuilder.BuildMatchedStatistics(results);
            Console.WriteLine(stats);

            Console.Read();
        }
    }
}
