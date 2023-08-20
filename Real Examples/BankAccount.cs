using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Examples
{
    public class BankAccount
    {
        private static int s_accountNumberSeed = 1234567890;
        private List<Transaction> transactions;
        public string Number { get;  }
        public string Owner { get; set; }
        public decimal Balance { 
            get 
            {
                decimal balance = 0;
                foreach (var transaction in transactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
           
        }

        public BankAccount(string name , decimal initialBalance)
        {
            Owner= name;
            
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;
            transactions = new List<Transaction>();
            MakeDeposit(initialBalance, DateTime.Now,"Initial balance");
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0){

                throw new ArgumentOutOfRangeException (nameof(amount), "Amount of deposit must be positive");
            }

            transactions.Add(new Transaction(amount, date,note));
            
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            transactions.Add(new Transaction(-amount, date, note));
        }

        //public string GetAccountHistory()
        //{
        //    var 
        //}

    }
}
