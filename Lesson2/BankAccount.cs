using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class BankAccount
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

        public bool Transfer(BankAccount accountToWithdraw, decimal value)
        {
            if (!accountToWithdraw.Withdraw(value))
                return false;

            AccountBalance += value;
            return true;
        }

        public static bool operator ==(BankAccount firstAcc, BankAccount secondAcc)
        {
            return firstAcc.Equals(secondAcc);
        }

        public static bool operator !=(BankAccount firstAcc, BankAccount secondAcc)
        {
            return !firstAcc.Equals(secondAcc);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not BankAccount || obj == null)
                return false;

            BankAccount otherAccount = obj as BankAccount;

            if (otherAccount.GetHashCode() == this.GetHashCode())            
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"number:{AccountNumber}, type:{AccountType}, balance:{AccountBalance}.";
        }
    }
}
