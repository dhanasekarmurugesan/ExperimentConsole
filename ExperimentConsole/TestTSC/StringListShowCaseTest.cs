using ExperimentConsole.TypeShowCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentConsole.TestTSC
{
    public class StringListShowCaseTest
    {
        public static void Execute()
        {
            StringList strings = new StringList { "ABC", "DEF" };

            Console.WriteLine($"{nameof(StringList)} contains following ({strings.Count}) entries:");

            strings.ForEach(t => Console.WriteLine(t));
        }
    }
}
