using System;
using System.Linq;

namespace Lotto.Selection
{
    public class LottoSelector
    {
        public static LottoSelection GenerateSelection()
        {
            // Selections are between 1 and 50, powerballs between 1 and 8
            var ballRange = Enumerable.Range(1, 50).ToList();
            var powerBallRange = Enumerable.Range(1, 8).ToList();
            var selection = new LottoSelection();

            for (int i = 0; i < 5; i++)
            {
                // pick random
                var randomBall = new Random().Next(ballRange.Count);

                while (selection.Balls[i] == ballRange[randomBall])
                {
                    randomBall = new Random().Next(ballRange.Count);
                }

                selection.Balls[i] = ballRange[randomBall];
                ballRange.Remove(randomBall);
            }


            for (int i = 0; i < 2; i++)
            {
                // pick random
                var randomBall = new Random().Next(powerBallRange.Count);

                while (selection.PowerBalls[i] == powerBallRange[randomBall])
                {
                    randomBall = new Random().Next(powerBallRange.Count);
                }

                selection.PowerBalls[i] = powerBallRange[randomBall];
                powerBallRange.Remove(randomBall);
            }

            return selection;
        }
    }
}
