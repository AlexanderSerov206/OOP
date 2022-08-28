using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class BankAccount
    {
        private int accountNumber = GetUniqueNumber();
        private decimal accountBalance;
        private AccountType accountType;
        private static int accountsCounter = 0;

        private static int GetUniqueNumber()
        {
            return ++accountsCounter;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public void SetAccountBalance(decimal balance)
        {
            accountBalance = balance;
        }

        public decimal GetAccountBalance()
        {
            return accountBalance;
        }

        public void SetAccountType(AccountType type)
        {
            accountType = type;
        }

        public AccountType GetAccountType()
        {
            return accountType;
        }
    }
}
