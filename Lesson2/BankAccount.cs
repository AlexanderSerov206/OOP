using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class BankAccount
    {
        private int accountNumber;
        private decimal accountBalance = 0;
        private AccountType accountType = AccountType.None;
        private static int accountsCounter = 0;

        public BankAccount()
        {
            accountNumber = GetUniqueNumber();
        }

        public BankAccount(AccountType accountType)
        {
            accountNumber = GetUniqueNumber();
            this.accountType = accountType;
        }

        public BankAccount(decimal accountBalance)
        {
            accountNumber = GetUniqueNumber();
            this.accountBalance = accountBalance;
        }

        public BankAccount(decimal accountBalance, AccountType accountType)
        {
            accountNumber = GetUniqueNumber();
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }

        private static int GetUniqueNumber()
        {
            return ++accountsCounter;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetAccountBalance()
        {
            return accountBalance;
        }

        public AccountType GetAccountType()
        {
            return accountType;
        }
    }
}
