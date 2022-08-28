using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class BankAccount
    {
        public int AccountNumber { get; init; } = GetUniqueNumber();
        public decimal AccountBalance { get; set; } = 0;
        public AccountType AccountType { get; set; } = AccountType.None;
        private static int AccountsCounter { get; set; } = 0;

        public BankAccount()
        {

        }

        public BankAccount(AccountType accountType)
        {
            AccountType = accountType;
        }

        public BankAccount(decimal accountBalance)
        {
            AccountBalance = accountBalance;
        }

        public BankAccount(decimal accountBalance, AccountType accountType)
        {
            AccountNumber = GetUniqueNumber();
            AccountBalance = accountBalance;
            AccountType = accountType;
        }

        private static int GetUniqueNumber()
        {
            return ++AccountsCounter;
        }

        public void Replenish(decimal value)
        {
            AccountBalance += value;
        }

        public bool Withdraw(decimal value)
        {
            if (AccountBalance < value)            
                return false;

            AccountBalance -= value;

            return true;
        }
    }
}
