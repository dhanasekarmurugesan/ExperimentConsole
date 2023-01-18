using ExperimentConsole.TestPSC;
using ExperimentConsole.TestTSC;
using System;

namespace ExperimentConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnePunchManShowCaseTest.Execute();
            StringListShowCaseTest.Execute();
            Console.ReadLine();
        }
    }
}
