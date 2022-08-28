namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount());
            accounts.Add(new BankAccount(AccountType.Card));
            accounts.Add(new BankAccount(103.4m));
            accounts.Add(new BankAccount(500.32m, AccountType.Deposit));

            foreach (BankAccount account in accounts)
            {
                Console.WriteLine($"Данные о счёте: \n\rТип: {account.GetAccountType()} \n\rНомер: {account.GetAccountNumber()} \n\rБаланс: {account.GetAccountBalance()}");
                Console.WriteLine("");
            }            

            Console.ReadKey(true);
        }
    }
}