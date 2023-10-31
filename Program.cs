using Cohesion_Coupling_Concern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cohesion_Coupling_Concern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expected balance number: ");

            int balance_number = Convert.ToInt32(Console.ReadLine());

            Account account = new Account(balance_number);

            Transaction transaction = new Transaction(account);

            Console.WriteLine("Enter your transaction type : withdraw/deposit ");
            string transactionType = Console.ReadLine();
/*            while (transactionType != "withdraw" || transactionType != "deposit")
            {
                Console.WriteLine("Wrong format, rechoose your transaction type");

                transactionType = Console.ReadLine();

            }*/
            
            Console.WriteLine("Enter your amount : ");

            decimal amount = Convert.ToDecimal(Console.ReadLine());

            transaction.MakeTransaction(transactionType, amount);

            Console.WriteLine("Account after transaction: ");
            Console.WriteLine(account.GetBalance());
        }
    }
}
