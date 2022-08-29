using Lesson3;
using System.Diagnostics;
using System.Text;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccountExample();
            StringReverseExample();
            FilterEmailsExample();

            Console.ReadKey(true);
        }

        private static void FilterEmailsExample()
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.FilterEmailsFromFile();

            Process.Start("C:\\Windows\\System32\\notepad.exe", "in.txt"); //открываем файлы в блокноте для наглядности
            Process.Start("C:\\Windows\\System32\\notepad.exe", "out.txt");
        }

        private static void StringReverseExample()
        {
            StringHandler stringHandler = new StringHandler();
            string stringToReverse = "123456789";
            string reversedString = stringHandler.Reverse(stringToReverse);

            Console.WriteLine($"Исходная строка: {stringToReverse}, перевёрнутая строка: {reversedString}");

            PrintDelimiter();
        }

        private static void BankAccountExample()
        {
            BankAccount accountToWithdraw = new BankAccount(500m, AccountType.Deposit);
            BankAccount accountToReplenish = new BankAccount(0, AccountType.Card);

            ShowAccountInfo(accountToWithdraw);
            ShowAccountInfo(accountToReplenish);

            Console.WriteLine("Попытка перевести 700");
            accountToReplenish.Transfer(accountToWithdraw, 700m); //попытка будет неуспешна, метод вернёт false

            Console.WriteLine("Попытка перевести 300");
            accountToReplenish.Transfer(accountToWithdraw, 300m); //попытка будет успешна, деньги переведутся, метод вернёт true

            ShowAccountInfo(accountToWithdraw);
            ShowAccountInfo(accountToReplenish);

            PrintDelimiter();
        }

        private static void ShowAccountInfo(BankAccount account)
        {
            Console.WriteLine($"Данные о счёте: \n\rТип: {account.AccountType} \n\rНомер: {account.AccountNumber} \n\rБаланс: {account.AccountBalance}");
            Console.WriteLine("");
        }

        private static void PrintDelimiter()
        {
            int width = Console.BufferWidth;

            StringBuilder builder = new StringBuilder();
            builder.Append('=', width);

            Console.WriteLine(builder.ToString());
        }
    }
}