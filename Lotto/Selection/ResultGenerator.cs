using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lotto.Selection
{
    public class ResultGenerator
    {
        public IEnumerable<LottoSelection> Get(int attempts)
        {
            Console.WriteLine("Starting...");
            var generatedSelections = new List<LottoSelection>();
            for (var i = 0; i < attempts; i++)
            {
                if (i % 100000 == 0) Console.Write(".");
                generatedSelections.Add(LottoSelector.GenerateSelection());
            }
            Console.WriteLine($"{attempts} results generated");
            return generatedSelections;
        }

        public async Task<IEnumerable<LottoSelection>> GenerateResults(int attepts) => await Task.Run(() => Get(attepts));
    }
}
