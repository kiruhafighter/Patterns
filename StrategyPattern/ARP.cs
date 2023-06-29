using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ARP : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ARP sent");
        }
    }
}
