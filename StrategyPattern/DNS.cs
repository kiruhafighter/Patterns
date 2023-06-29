using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DNS : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ctor");
        }
    }
}
