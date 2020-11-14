namespace Lotto.Extensions
{
    public static class IntExtensions
    {
        public static string PadToString(this int value, int padLength)
        {
            if (padLength < 0) padLength = 0;
            return value.ToString().PadLeft(padLength);
        }
    }
}
