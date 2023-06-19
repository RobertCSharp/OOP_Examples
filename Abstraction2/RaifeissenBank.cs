using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    internal class RaifeissenBank : Bank
    {
        public RaifeissenBank(string depositEuro, string depositUsd, int clientNumber, int branchNumber) 
            : base(depositEuro, depositUsd, clientNumber, branchNumber)
        {
        }

        public override void PrintSchedule()
        {
            Console.WriteLine("08:00 - :14:30");
        }
    }
}
