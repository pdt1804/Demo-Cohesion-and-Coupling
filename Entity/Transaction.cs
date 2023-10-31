using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion_Coupling_Concern.Entity
{
    public class Transaction
    {
        private Account account;

        public Transaction(Account account)
        {
            this.account = account;
        }

        public void MakeTransaction(string transactionType, decimal amount)
        {
            if (transactionType == "withdraw")
            {
                account.Withdraw(amount);
            }
            else if (transactionType == "deposit")
            {
                account.Deposit(amount);
            }
        }
    }
}


