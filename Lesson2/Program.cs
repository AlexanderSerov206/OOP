namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.SetAccountNumber(1);
            account.SetAccountBalance(100.25m);
            account.SetAccountType(AccountType.Deposit);

            Console.Write($"Данные о счёте: \n\rТип: {account.GetAccountType()} \n\rНомер: {account.GetAccountNumber()} \n\rБаланс: {account.GetAccountBalance()}");
            Console.ReadKey(true);
        }
    }
}