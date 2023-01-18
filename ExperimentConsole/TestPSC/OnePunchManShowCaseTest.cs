using ExperimentConsole.PatternShowCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentConsole.TestPSC
{
    public class OnePunchManShowCaseTest
    {
        public static void Execute()
        {
            var instance = OnePunchMan.GetInstance();
            var freshHash = instance.GetHashCode();


            //now call getInstance again to check if it sticks to the pattern
            instance = OnePunchMan.GetInstance();
            var newHash = instance.GetHashCode();

            Console.WriteLine($"New Instance: {freshHash} | Existing Instance: {newHash}");
            Console.WriteLine($"{(freshHash.Equals(newHash) ? "Singleton Persists" : "Singleton Breaks")}");

        }
    }
}
