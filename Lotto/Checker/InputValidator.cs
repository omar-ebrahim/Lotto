using System.Collections.Generic;
using System.Linq;

namespace Lotto.Checker
{
    public class InputValidator
    {
        public static bool TryValidateInput(IEnumerable<string> input, int count, int max, out string error)
        {
            if (input.Any(x => !int.TryParse(x, out _)))
            {
                error = "Please enter only whole numbers";
                return false;
            }
            else if (input.GroupBy(x => x).Any(y => y.Count() > 1))
            {
                error = "You have entered the same value more than once";
                return false;
            }
            else if (input.Count() != count)
            {
                error = $"You have not entered the {count} values";
                return false;
            }
            else if (input.Any(x => int.Parse(x) < 1 || int.Parse(x) > max))
            {
                error = $"Values must be between 1 and {max}";
                return false;
            }

            error = "";
            return true;
        }
    }
}
