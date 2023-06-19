using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    internal abstract class Bank
    {
        public string DepositEuro { get; set; }
        public string DepositUsd  { get; set; }
        public int ClientNumber { get; set; }
        public int  BranchNumber { get; set; }

        public Bank(string depositEuro, string depositUsd, int clientNumber, int branchNumber)
        {
            DepositEuro = depositEuro;
            DepositUsd = depositUsd;
            ClientNumber = clientNumber;
            BranchNumber = branchNumber;
        }

        public override string ToString()
        {
          return  $"DepositEuro: {DepositEuro} DepositUsd: {DepositUsd} ClientNumber: {ClientNumber} BranchNumber: {BranchNumber}";
        }

        public abstract void PrintSchedule();
    }
}
