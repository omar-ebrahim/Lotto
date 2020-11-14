using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotto.Selection
{
    public class LottoSelection
    {
        public const int BallCount = 5;
        public const int PowerBallCount = 2;

        public int MatchedBalls { get; set; }

        public int MatchedPowerBalls { get; set; }

        public LottoSelection()
        {
            Balls = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, };
            PowerBalls = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 } };
        }

        public Dictionary<int, int> Balls { get; set; }

        public Dictionary<int, int> PowerBalls { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Balls: {string.Join(", ", Balls.Select(x => x.Value).OrderBy(x => x))}.");
            sb.AppendLine($"PowerBalls: {string.Join(", ", PowerBalls.Select(x => x.Value).OrderBy(x => x))}");
            sb.AppendLine($"Matched balls: {MatchedBalls}. Matched Powerballs: {MatchedPowerBalls}");
            return sb.ToString();
        }
    }
}
