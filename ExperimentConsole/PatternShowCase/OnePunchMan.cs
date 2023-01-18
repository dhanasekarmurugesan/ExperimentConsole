using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentConsole.PatternShowCase
{
    /// <summary>
    /// Represents a Singleton Class
    /// </summary>
    public class OnePunchMan
    {
        private static OnePunchMan OnePunch { get; set; }

        private OnePunchMan() { }

        public static OnePunchMan GetInstance()
        {
            if (OnePunch == null)
                //create instance if not already instantiated
                CreateInstance();
            return OnePunch;
        }

        private static void CreateInstance()
        {
            OnePunch = new OnePunchMan();
        }
    }
}
