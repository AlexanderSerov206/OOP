namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(500m, AccountType.Deposit);

            ShowAccountInfo(account);
            Console.WriteLine("Попытка снять 300 с баланса.");
            account.Withdraw(300);

            ShowAccountInfo(account);
            Console.WriteLine("Попытка снять 500 с баланса.");
            account.Withdraw(500);

            ShowAccountInfo(account);
            Console.WriteLine("Добавление 500 на баланс.");
            account.Replenish(500);

            ShowAccountInfo(account);

            Console.ReadKey(true);
        }

        private static void ShowAccountInfo(BankAccount account)
        {
            Console.WriteLine($"Данные о счёте: \n\rТип: {account.AccountType} \n\rНомер: {account.AccountNumber} \n\rБаланс: {account.AccountBalance}");
            Console.WriteLine("");
        }
    }
}