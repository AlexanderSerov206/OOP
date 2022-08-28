namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Array accountTypes = Enum.GetValues(typeof(AccountType));
                BankAccount account = new BankAccount();

                account.SetAccountBalance(Convert.ToDecimal(random.NextDouble()));
                account.SetAccountType((AccountType)accountTypes.GetValue(random.Next(accountTypes.Length)));

                Console.WriteLine($"Данные о счёте: \n\rТип: {account.GetAccountType()} \n\rНомер: {account.GetAccountNumber()} \n\rБаланс: {account.GetAccountBalance()}");
                Console.WriteLine("");
            }

            Console.ReadKey(true);
        }
    }
}