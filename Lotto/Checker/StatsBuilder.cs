using Lotto.Extensions;
using Lotto.Selection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotto.Checker
{
    public static class StatsBuilder
    {
        public static string BuildMatchedStatistics(IEnumerable<LottoSelection> results)
        {
            var sb = new StringBuilder();

            var padLeftLength = $"{results.Count()}".Length + " Amount Matched".Length;
            var secondColumnString = "-".PadLeft(padLeftLength, '-');

            var matched0Balls0PowerBalls = results.Count(x => x.MatchedBalls == 0 && x.MatchedPowerBalls == 0).PadToString(padLeftLength);
            var matched0Balls1PowerBalls = results.Count(x => x.MatchedBalls == 0 && x.MatchedPowerBalls == 1).PadToString(padLeftLength);
            var matched0Balls2PowerBalls = results.Count(x => x.MatchedBalls == 0 && x.MatchedPowerBalls == 2).PadToString(padLeftLength);
            
            var matched1Balls0PowerBalls = results.Count(x => x.MatchedBalls == 1 && x.MatchedPowerBalls == 0).PadToString(padLeftLength);
            var matched1Balls1PowerBalls = results.Count(x => x.MatchedBalls == 1 && x.MatchedPowerBalls == 1).PadToString(padLeftLength);
            var matched1Balls2PowerBalls = results.Count(x => x.MatchedBalls == 1 && x.MatchedPowerBalls == 2).PadToString(padLeftLength);
            
            var matched2Balls0PowerBalls = results.Count(x => x.MatchedBalls == 2 && x.MatchedPowerBalls == 0).PadToString(padLeftLength);
            var matched2Balls1PowerBalls = results.Count(x => x.MatchedBalls == 2 && x.MatchedPowerBalls == 1).PadToString(padLeftLength);
            var matched2Balls2PowerBalls = results.Count(x => x.MatchedBalls == 2 && x.MatchedPowerBalls == 2).PadToString(padLeftLength);
            
            var matched3Balls0PowerBalls = results.Count(x => x.MatchedBalls == 3 && x.MatchedPowerBalls == 0).PadToString(padLeftLength);
            var matched3Balls1PowerBalls = results.Count(x => x.MatchedBalls == 3 && x.MatchedPowerBalls == 1).PadToString(padLeftLength);
            var matched3Balls2PowerBalls = results.Count(x => x.MatchedBalls == 3 && x.MatchedPowerBalls == 2).PadToString(padLeftLength);
            
            var matched4Balls0PowerBalls = results.Count(x => x.MatchedBalls == 4 && x.MatchedPowerBalls == 0).PadToString(padLeftLength);
            var matched4Balls1PowerBalls = results.Count(x => x.MatchedBalls == 4 && x.MatchedPowerBalls == 1).PadToString(padLeftLength);
            var matched4Balls2PowerBalls = results.Count(x => x.MatchedBalls == 4 && x.MatchedPowerBalls == 2).PadToString(padLeftLength);
            
            var matched5Balls0PowerBalls = results.Count(x => x.MatchedBalls == 5 && x.MatchedPowerBalls == 0).PadToString(padLeftLength);
            var matched5Balls1PowerBalls = results.Count(x => x.MatchedBalls == 5 && x.MatchedPowerBalls == 1).PadToString(padLeftLength);
            var matched5Balls2PowerBalls = results.Count(x => x.MatchedBalls == 5 && x.MatchedPowerBalls == 2).PadToString(padLeftLength);

            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"|Matched                 | Amount Matched {"".PadLeft(results.Count().ToString().Length, ' ')} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 0 balls, 0 powerballs  | {matched0Balls0PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 0 balls, 1 powerballs  | {matched0Balls1PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 0 balls, 2 powerballs  | {matched0Balls2PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 1 balls, 0 powerballs  | {matched1Balls0PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 1 balls, 1 powerballs  | {matched1Balls1PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 1 balls, 2 powerballs  | {matched1Balls2PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 2 balls, 0 powerballs  | {matched2Balls0PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 2 balls, 1 powerballs  | {matched2Balls1PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 2 balls, 2 powerballs  | {matched2Balls2PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 3 balls, 0 powerballs  | {matched3Balls0PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 3 balls, 1 powerballs  | {matched3Balls1PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 3 balls, 2 powerballs  | {matched3Balls2PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 4 balls, 0 powerballs  | {matched4Balls0PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 4 balls, 1 powerballs  | {matched4Balls1PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 4 balls, 2 powerballs  | {matched4Balls2PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 5 balls, 0 powerballs  | {matched5Balls0PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 5 balls, 1 powerballs  | {matched5Balls1PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");
            sb.AppendLine($"| 5 balls, 2 powerballs  | {matched5Balls2PowerBalls} |");
            sb.AppendLine($"|------------------------|-{secondColumnString}-|");

            return sb.ToString();
        }
    }
}
