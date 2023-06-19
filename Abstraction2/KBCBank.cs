using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    internal class KBCBank : Bank
    {
        public KBCBank(string depositEuro, string depositUsd, int clientNumber, int branchNumber) 
            : base(depositEuro, depositUsd, clientNumber, branchNumber)
        {
        }

        public override void PrintSchedule()
        {
            Console.WriteLine("12:00 - 19:00");
        }
    }
}
