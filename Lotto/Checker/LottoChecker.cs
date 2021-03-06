﻿using Lotto.Selection;
using System.Collections.Generic;
using System.Linq;

namespace Lotto.Checker
{
    public class LottoChecker
    {
        public static bool CheckResults(LottoSelection userSelection, IEnumerable<LottoSelection> generatedSelectionsToCheckAgainst)
        {
            var jackpot = false;
            foreach (var selection in generatedSelectionsToCheckAgainst)
            {
                var win = selection.Balls[0] == userSelection.Balls[0] &&
                    selection.Balls[1] == userSelection.Balls[1] &&
                    selection.Balls[2] == userSelection.Balls[2] &&
                    selection.Balls[3] == userSelection.Balls[3] &&
                    selection.Balls[4] == userSelection.Balls[4];
                if (win)
                {
                    jackpot = true;
                }

                selection.MatchedBalls = userSelection.Balls.Select(x => x.Value).Intersect(selection.Balls.Select(y => y.Value)).Count();
                selection.MatchedPowerBalls = userSelection.PowerBalls.Select(x => x.Value).Intersect(selection.PowerBalls.Select(y => y.Value)).Count();
            }
            return jackpot;
        }
    }
}
