using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
        public BankAccount(int accountNumbe, decimal balance, string owner)
        {
            AccountNumber = accountNumbe;
            Balance = balance;
            Owner = owner;
        }

    }
}
