using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling_Concern.Entity
{
    public class Account
    {
        private decimal balance;

        public Account(decimal initialBalance)
        {
            balance = initialBalance;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Transaction successful");
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
    }
}
